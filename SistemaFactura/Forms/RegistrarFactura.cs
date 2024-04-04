namespace SistemaFactura
{
    public partial class RegistrarFactura : Form
    {
        public RegistrarFactura(long nit, string nombre)
        {
            InitializeComponent();
            tbNombreRazon.Text = nombre;
            tbNit.Text = nit.ToString();
        }
    }
}
