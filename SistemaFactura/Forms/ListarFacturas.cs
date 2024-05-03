using SistemaFactura.Models;
using SistemaFactura.Services;
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
    public partial class ListarFacturas : Form
    {
        private readonly GestionarFactura gestionarFactura;
        private readonly long nit_usuario;
        public ListarFacturas(long nit_usuario)
        {
            InitializeComponent();
            gestionarFactura = new GestionarFactura();
            this.nit_usuario = nit_usuario;
        }

        private void ListarFacturas_Load(object sender, EventArgs e)
        {
            cbxTipo.SelectedIndex = 0;
            cbMensual.Checked = cbTrimestral.Checked = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvListaFacturas.Rows.Clear();
            cbMensual.Checked = cbTrimestral.Checked = false;
            DateTime intervalo = dtpFecha.Value;
            List<IFactura> facturas = gestionarFactura.ListaFacturas(nit_usuario, cbxTipo.SelectedIndex, intervalo);

            if (facturas.Count != 0)
            {
                foreach (IFactura factura in facturas)
                {
                    string tipoDescargoValue = factura.tipo_especifico ? "Mensual" : factura.tipo_general ? "Trimestral" : "";
                    string dateOnly = factura.fecha_emision.ToString("ddd dd MMM yyyy");

                    object[] rowData = [
                        factura.nombre_razon,
                        factura.nit_emisor,
                        factura.numero_factura,
                        factura.cod_autorizacion,
                        dateOnly,
                        factura.monto,
                        factura.monto_imponible,
                        factura.cod_control,
                        tipoDescargoValue
                    ];

                    dgvListaFacturas.Rows.Add(rowData);
                }
            }
            else { MessageBox.Show("No tienes facturas registradas en el mes o fecha seleccionada."); }
        }

        private void FilterFacturas(string tipoDescargo)
        {
            dgvListaFacturas.EndEdit();
            foreach (DataGridViewRow row in dgvListaFacturas.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataGridViewCell tipoDescargoCell = row.Cells["tipo_descargo"];
                    if (tipoDescargoCell.Value != null && tipoDescargoCell.Value.ToString() == tipoDescargo)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void cbMensual_CheckedChanged(object sender, EventArgs e)
        {
            SwitchCbDescargo(cbMensual.Checked, cbTrimestral.Checked);
        }

        private void cbTrimestral_CheckedChanged(object sender, EventArgs e)
        {
            SwitchCbDescargo(cbMensual.Checked, cbTrimestral.Checked);
        }

        private void SwitchCbDescargo(bool mensual, bool trimestral)
        {
            if (mensual && !trimestral)
            {
                FilterFacturas("Mensual");
            }
            else if (!mensual && trimestral)
            {
                FilterFacturas("Trimestral");
            }
            else
            {
                ClearFilterFacturas();
            }
        }

        private void ClearFilterFacturas()
        {
            dgvListaFacturas.EndEdit();
            foreach (DataGridViewRow row in dgvListaFacturas.Rows)
            {
                if(!row.IsNewRow)
                    row.Visible = true;
            }
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxTipo.SelectedIndex)
            {
                case 0:
                    ttFecha.Show("Seleccione el día del que desea ver las facturas registradas.", dtpFecha, dtpFecha.Width, 10, 5000);
                    lbFecha.Text = "Fecha Día:";
                    break;
                case 1:
                    ttFecha.Show("Seleccione cualquier fecha del MES que desea ver las facturas registradas.", dtpFecha, dtpFecha.Width, 10, 10000);
                    lbFecha.Text = "Fecha en el Mes:";
                    break;
                case 2:
                    ttFecha.Show("Seleccione cualquier fecha del TRIMESTRE que desea ver las facturas registradas." +
                        "\nEnero - Marzo, Abril - Junio, Julio - Septiembre, Octubre - Diciembre", dtpFecha, dtpFecha.Width, 10, 10000);
                    lbFecha.Text = "Fecha en Trimestre:";
                    break;
            }
        }
    }
}
