using iTextSharp.text;
using iTextSharp.text.pdf;
using SistemaFactura.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Text;


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

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al registrar la factura en la base de datos", ex);
            }
            finally
            {
                database.cerrarBD();
            }
        }

        public void ExportarFacturaCSV(long nit_usuario, long nit_emisor, int numero_factura, string cod_autorizacion,
    string nombre_razon, DateTime fecha_emision, decimal monto, decimal monto_imponible, string cod_control,
    bool tipo_especifico, bool tipo_general, string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentNullException(nameof(filePath), "El argumento filePath no puede ser nulo o vacío");
                }

                // Crear o sobrescribir el archivo CSV
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    // Escribir encabezados
                    writer.WriteLine("NitUsuario,NitEmisor,NumeroFactura,CodAutorizacion,NombreRazon,FechaEmision,Monto,MontoImponible,CodControl,TipoEspecifico,TipoGeneral");

                    // Escribir los datos de la factura
                    writer.WriteLine($"{nit_usuario},{nit_emisor},{numero_factura},{cod_autorizacion},{nombre_razon},{fecha_emision},{monto},{monto_imponible},{cod_control},{tipo_especifico},{tipo_general}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al exportar la factura a CSV", ex);
            }
        }


        public void ConvertirCSVaPDF(string csvFilePath, string pdfFilePath)
        {
            try
            {
                // Leer los datos del archivo CSV
                string csvData = File.ReadAllText(csvFilePath);

                // Generar un documento PDF
                // Aquí debes utilizar la lógica para generar el PDF a partir de los datos del CSV
                // Esto podría requerir el uso de una biblioteca como iTextSharp o PdfSharp

                // Ejemplo de cómo podrías usar iTextSharp para crear un PDF básico
                using (FileStream stream = new FileStream(pdfFilePath, FileMode.Create))
                {
                    Document document = new Document();
                    PdfWriter.GetInstance(document, stream);
                    document.Open();

                    // Aquí deberías procesar los datos del archivo CSV y agregarlos al documento PDF

                    document.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al convertir el archivo CSV a PDF", ex);
            }
        }

        public List<Factura> ListaFacturas(long nit_usuario)
        {
            List<Factura> facturas = new List<Factura>();
            try
            {
                database.conectarBD();
                string sql = "SELECT nit_usuario, nit_emisor, numero_factura, cod_autorizacion, nombre_razon, " +
                    "fecha_emision, monto, monto_imponible, cod_control, tipo_especifico, tipo_general " +
                    "FROM factura WHERE nit_usuario = @NIT_USUARIO";
                
                using (SqlCommand cmd = new SqlCommand(sql, database.con))
                {
                    cmd.Parameters.AddWithValue("@NIT_USUARIO", nit_usuario);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Factura factura = new Factura(
                                Convert.ToInt64(reader["nit_usuario"]),
                                Convert.ToInt64(reader["nit_emisor"]),
                                Convert.ToInt32(reader["numero_factura"]),
                                reader["cod_autorizacion"].ToString(),
                                reader["nombre_razon"].ToString(),
                                Convert.ToDateTime(reader["fecha_emision"]),
                                Convert.ToDecimal(reader["monto"]),
                                Convert.ToDecimal(reader["monto_imponible"]),
                                reader["cod_control"].ToString(),
                                Convert.ToBoolean(reader["tipo_especifico"]),
                                Convert.ToBoolean(reader["tipo_general"])
                            );

                            facturas.Add(factura);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la lista de facturas: " + ex.Message);
            }
            finally { database.cerrarBD(); }
            return facturas;
        }
    }
}
