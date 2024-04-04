using SistemaFactura.Services;

namespace SistemaFactura
{
    public partial class RegistrarFactura : Form
    {
        private GestionarFactura gestionarFactura;
        private long nit_usuario;
        public RegistrarFactura(long nit, string nombre)
        {
            InitializeComponent();
            tbNombreUsuario.Text = nombre;
            tbNitUsuario.Text = nit.ToString();
            gestionarFactura = new GestionarFactura();
            this.nit_usuario = nit;
        }

        private void tbNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            long nit_emisor = long.Parse(tbNit.Text);
            int numero_factura = int.Parse(tbNumFactura.Text);
            string cod_autorizacion = tbAutorizacion.Text;
            string nombre_razon = tbNombreRazon.Text;
            DateTime fecha_emision = dtFecha.Value.Date;
            string monto = tbMontoTotal.Text;
            string monto_imponible = tbMontoImponible.Text;
            string cod_control = tbCodigoControl.Text;
            bool tipo_especifico = rbMensual.Checked;
            bool tipo_general = rbTrimestral.Checked;

            if (nit_emisor < 100000)
            {
                MessageBox.Show("Por favor ingrese un NIT válido.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numero_factura < 1)
            {
                MessageBox.Show("Por favor ingrese un número de factura válido.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(cod_autorizacion))
            {
                MessageBox.Show("Código de Autorización requerido.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(monto))
            {
                MessageBox.Show("Monto Total requerido.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!tipo_especifico && !tipo_general)
            {
                MessageBox.Show("Elija el Tipo de Descargo.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (String.IsNullOrEmpty(nombre_razon)) { nombre_razon = ""; }
                if (String.IsNullOrEmpty(cod_control)) { cod_control = ""; }

                decimal monto_total = decimal.Parse(monto);
                decimal monto_imponible_money = decimal.Parse(monto_imponible);

                if (gestionarFactura.Registrar(nit_usuario, nit_emisor, numero_factura,
                    cod_autorizacion, nombre_razon, fecha_emision, monto_total,
                    monto_imponible_money, cod_control, tipo_especifico, tipo_general))
                {
                    MessageBox.Show("Factura registrada exitosamente!");
                }
            }
        }



        private void tbMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 45)
            {
                TextBox t = (TextBox)sender;
                int cursorPosition = t.Text.Length - t.SelectionStart;      // Text in the box and Cursor position

                if (e.KeyChar == 45)
                    t.Text = t.Text[0] == 45 ? t.Text = t.Text[1..] : "-" + t.Text;
                else
                    if (t.Text.Length < 20)
                    t.Text = (decimal.Parse(t.Text.Insert(t.SelectionStart, e.KeyChar.ToString())
                                            .Replace(",", "").Replace(".", "")) / 100).ToString("N2");

                t.SelectionStart = (t.Text.Length - cursorPosition < 0 ? 0 : t.Text.Length - cursorPosition);
            }
            e.Handled = true;
        }
        private void tbMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)     // Deals with BackSpace e Delete keys
            {
                TextBox t = (TextBox)sender;
                int cursorPosition = t.Text.Length - t.SelectionStart;

                string Left = t.Text.Substring(0, t.Text.Length - cursorPosition).Replace(".", "").Replace(",", "");
                string Right = t.Text.Substring(t.Text.Length - cursorPosition).Replace(".", "").Replace(",", "");

                if (Left.Length > 0)
                {
                    Left = Left.Remove(Left.Length - 1);                            // Take out the rightmost digit
                    t.Text = (decimal.Parse(Left + Right) / 100).ToString("N2");
                    t.SelectionStart = (t.Text.Length - cursorPosition < 0 ? 0 : t.Text.Length - cursorPosition);
                }
                e.Handled = true;
            }

            if (e.KeyCode == Keys.End)                                  // Treats End key
            {
                TextBox t = (TextBox)sender;
                t.SelectionStart = t.Text.Length;                       // Moves the cursor o the rightmost position
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Home)                                 // Trata tecla Home
            {
                TextBox t = (TextBox)sender;
                t.Text = 0.ToString("N2");                              // Set field value to zero 
                t.SelectionStart = t.Text.Length;                       // Moves the cursor o the rightmost position
                e.Handled = true;
            }
        }
        private void tbMoney_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;                                // Desliga seleção de texto
            t.SelectionStart = t.Text.Length;
        }

        private void cbMontoImponible_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMontoImponible.Checked)
            {
                tbMontoImponible.Enabled = true;
                tbMontoTotal.TextChanged -= tbMontoTotal_TextChanged;
            }
            else
            {
                tbMontoImponible.Enabled = false;
                tbMontoImponible.Text = tbMontoTotal.Text;
                tbMontoTotal.TextChanged += tbMontoTotal_TextChanged;
            }
        }

        private void tbMontoTotal_TextChanged(object sender, EventArgs e)
        {
            tbMontoImponible.Text = tbMontoTotal.Text;
        }

        private void tbNitUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNumFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbAutorizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbNombreRazon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbCodigoControl_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCodigoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
