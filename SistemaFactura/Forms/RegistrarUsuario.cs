using SistemaFactura.Services;

namespace SistemaFactura
{
    public partial class RegistrarUsuario : Form
    {
        private GestionarUsuario gestionarUsuario;
        private long nit_ci;
        public RegistrarUsuario(long nit)
        {
            InitializeComponent();
            tbNit.Text = nit.ToString();
            nit_ci = nit;
            gestionarUsuario = new GestionarUsuario();
        }

        private void btRegistrarse_Click(object sender, EventArgs e)
        {
            string nombre = tbNombreRazon.Text;
            if (String.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor ingrese su nombre o razón social.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (gestionarUsuario.Registrar(nit_ci, nombre))
                {
                    Login.MostrarFormFactura(nit_ci, nombre, this);
                }
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
            //Application.Run(new FormLogin());
        }

        private void FormRegistrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
