using SistemaFactura.Conexion;
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
            string nombre_razon, string fecha_emision, string monto, string monto_imponible, string cod_control,
            bool tipo_especifico, bool tipo_general)
        {
            try
            {
                database.conectarBD();

                string sql = "INSERT INTO factura(nit_usuario, nit_emisor, numero_factura, cod_autorizacion," +
                    "nombre_razon, fecha_emision, monto, monto_imponible, cod_control, tipo_especifico, tipo_general)" +
                    "VALUES(@NIT_USUARIO, @NIT_EMISOR, @NUMERO_FACTURA, @COD_AUTORIZACION, @NOMBRE_RAZON," +
                    "@FECHA_EMISION, @MONTO, @MONTO_IMPONIBLE, @COD_CONTROL, @TIPO_ESPECIFICO, @TIPO_GENERAL)";
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
    }
}
