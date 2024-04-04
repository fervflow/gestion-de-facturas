﻿using SistemaFactura.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFactura.Services
{
    internal class GestionarFactura
    {
        private Database database;
        public GestionarFactura()
        {
            database = new Database();
        }

        public bool Registrar(long nit_usuario, long nit_emisor, int numero_factura, string cod_autorizacion,
            string nombre_razon, DateTime fecha_emision, decimal monto, decimal monto_imponible, string cod_control,
            bool tipo_especifico, bool tipo_general)
        {
            try
            {
                database.conectarBD();

                string sql = "INSERT INTO factura(nit_usuario, nit_emisor, numero_factura, cod_autorizacion, " +
                    "nombre_razon, fecha_emision, monto, monto_imponible, cod_control, tipo_especifico, tipo_general) " +
                    "VALUES(@NIT_USUARIO, @NIT_EMISOR, @NUMERO_FACTURA, @COD_AUTORIZACION, @NOMBRE_RAZON, @FECHA_EMISION, " +
                    "ROUND(@MONTO, 2), ROUND(@MONTO_IMPONIBLE, 2), @COD_CONTROL, @TIPO_ESPECIFICO, @TIPO_GENERAL)";
                using (SqlCommand cmd = new SqlCommand(sql, database.con))
                {
                    cmd.Parameters.AddWithValue("@NIT_USUARIO", nit_usuario);
                    cmd.Parameters.AddWithValue("@NIT_EMISOR", nit_emisor);
                    cmd.Parameters.AddWithValue("@NUMERO_FACTURA", numero_factura);
                    cmd.Parameters.AddWithValue("@COD_AUTORIZACION", cod_autorizacion);
                    cmd.Parameters.AddWithValue("@NOMBRE_RAZON", nombre_razon);
                    cmd.Parameters.AddWithValue("@FECHA_EMISION", fecha_emision);
                    cmd.Parameters.AddWithValue("@MONTO", monto);
                    cmd.Parameters.AddWithValue("@MONTO_IMPONIBLE", monto_imponible);
                    cmd.Parameters.AddWithValue("@COD_CONTROL", cod_control);
                    cmd.Parameters.AddWithValue("@TIPO_ESPECIFICO", tipo_especifico);
                    cmd.Parameters.AddWithValue("@TIPO_GENERAL", tipo_general);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return (rowsAffected > 0);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al registrar la factura:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error inesperado:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally { database.cerrarBD(); }
        }
        
        public List<Factura> ObtenerListaFacturas(long nit_usuario)
        {
            List<Factura> Facturas = new List<Factura>();
            try
            {
                database.conectarBD();
                string sql = "SELECT * FROM factura WHERE nit_usuario = @NIT_USUARIO";
                
                using(SqlCommand cmd = new SqlCommand(sql, database.con))
                {
                    cmd.Parameters.AddWithValue("@NIT_USUARIO", nit_usuario);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Factura factura = new Factura(
                            Convert.ToInt64(reader["nit_usuario"]),
                            Convert.ToInt64(reader["nit_emisor"]),
                            Convert.ToInt32(reader["numero_factura"],
                            reader["cod_autorizacion"].ToString(),
                            reader["nombre_razon"].ToString(),
                            Convert.ToDateTime(reader["fecha_emision"]),
                            Convert.ToDecimal(reader["monto"]),
                            Convert.ToDecimal(reader["monto_imponible"]),
                            reader["cod_control"].ToString(),
                            Convert.ToBoolean(reader["tipo_especifico"]),
                            Convert.ToBoolean(reader["tipo_general"])
                        );
                    }
                }
            }
            return Facturas;
        }

    }
}
