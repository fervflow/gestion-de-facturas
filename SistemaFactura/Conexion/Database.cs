using System.Data.SqlClient;

namespace SistemaFactura.Conexion
{
    internal class Database
    {
        private string cadenaConexion;
        public SqlConnection con { get; set; }
        public Database()
        {
            cadenaConexion = @"Data Source=localhost;Initial Catalog=sistema_factura;User ID=factura_admin;Password=admin123";
            con = new SqlConnection(cadenaConexion);
        }
        public void conectarBD()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la Base de Datos:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al cerrar la conexion a la Base de Datos:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
