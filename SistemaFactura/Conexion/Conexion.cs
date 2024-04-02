using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaFactura.Conexion
{
    internal class Conexion
    {
        private string cadenaConexion;
        public SqlConnection con { get; set; }
        public Conexion()
        {
            cadenaConexion = @"Data Source=localhost;Initial Catalog=agenda;User ID=sa;Password=sa123";
        }
        public void conectarBD()
        {
            try
            {
                con = new SqlConnection(cadenaConexion);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar la BD: " + ex.Message);
            }
        }
        public void cerrarBD()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la BD: " + ex.Message);
            }
        }

    }
}
