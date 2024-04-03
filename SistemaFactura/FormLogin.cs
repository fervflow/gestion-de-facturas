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
    }
}
