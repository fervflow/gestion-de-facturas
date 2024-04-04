using SistemaFactura.Conexion;
using System.Data.SqlClient;

namespace SistemaFactura.Services
{
    internal class GestionarUsuario
    {

        private Database database;
        public GestionarUsuario()
        {
            database = new Database();
        }

        public bool Registrar(long nit_ci, string nombre)
        {
            try
            {
                database.conectarBD();

                string sql = "INSERT INTO usuario OUTPUT Inserted.nit_ci VALUES (@NIT_CI, @NOMBRE)";
                SqlCommand cmd = new SqlCommand(sql, database.con);
                cmd.Parameters.AddWithValue("@NIT_CI", nit_ci);
                cmd.Parameters.AddWithValue("@NOMBRE", nombre);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    database.cerrarBD();
                    return (rowsAffected > 0);
                }
                catch (SqlException ex)
                {
                    cmd.Dispose();
                    database.cerrarBD();
                    MessageBox.Show("Error al crear el usuario:", ex.Message);
                    return false;
                }
            }
            catch (Exception ex)
            {
                database.cerrarBD();
                MessageBox.Show("Error inesperado:\n" + ex.Message);
                return false;
            }
        }

        public string Acceder(long nit)
        {
            try
            {
                database.conectarBD();

                string sql = "SELECT nombre FROM usuario WHERE nit_ci = @NIT_CI";
                using (SqlCommand cmd = new SqlCommand(sql, database.con))
                {
                    cmd.Parameters.AddWithValue("@NIT_CI", nit);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al acceder:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally { database.cerrarBD(); }
        }
    }
}
