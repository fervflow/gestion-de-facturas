namespace SistemaFactura
{
    public partial class RegistrarFactura : Form
    {
        public RegistrarFactura(long nit, string nombre)
        {
            InitializeComponent();
            tbNombreUsuario.Text = nombre;
            tbNitUsuario.Text = nit.ToString();
        }

        private void RegistrarFactura_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tbNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
