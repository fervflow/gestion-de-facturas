namespace SistemaFactura
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario formRegistrarUsuario = new FormRegistrarUsuario();
            formRegistrarUsuario.ShowDialog();
        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
