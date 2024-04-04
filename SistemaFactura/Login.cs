using SistemaFactura.Services;
using SistemaFactura.Forms;

namespace SistemaFactura
{
    public partial class Login : Form
    {
        private GestionarUsuario gestionarUsuario;
        public Login()
        {
            InitializeComponent();
            gestionarUsuario = new GestionarUsuario();
        }
        public static void MostrarFormFactura(long nit_ci, string nombre, Form formActual)
        {
            Menu menu = new Menu(nit_ci, nombre);
            menu.FormClosed += (s, args) => formActual.Close();
            formActual.Hide();
            MessageBox.Show("Bienvenido/a:\n" + nombre, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            menu.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            long nit_ci = long.Parse(tbNit.Text);
            string nombre = gestionarUsuario.Acceder(nit_ci);

            if (nombre == null)
            {
                RegistrarUsuario formRegistrarUsuario = new RegistrarUsuario(nit_ci);
                formRegistrarUsuario.FormClosed += (s, args) => this.Close();
                this.Hide();
                formRegistrarUsuario.Show();
            }
            else
            {
                MostrarFormFactura(nit_ci, nombre, this);
            }
        }

        private void tbNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbNit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
