using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFactura.Forms
{
    public partial class Menu : Form
    {
        long nit;
        string nom;
        public Menu(long nit, string nombre)
        {
            InitializeComponent();
            this.nit = nit;
            this.nom = nombre;
        }
        private Form activeForm = null;
        private void ChildForm_SizeChanged(object sender, EventArgs e)
        {
            ResizeParentFormToFitChildForm(sender as Form);
        }
        private void ResizeParentFormToFitChildForm(Form childForm)
        {
            if (childForm != null && childForm.WindowState != FormWindowState.Minimized)
            {
                this.ClientSize = childForm.Size;
            }
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.SizeChanged += ChildForm_SizeChanged;
            pContenedor.Controls.Add(childForm);
            pContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRegistrarFact_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistrarFactura(nit, nom));
        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            openChildForm(new ListarFacturas(nit));
        }
    }

}
