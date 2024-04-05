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
        private GestionarFactura gestionarFactura;
        public ListarFacturas()
        {
            InitializeComponent();
            gestionarFactura = new GestionarFactura();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Factura> facturas = gestionarFactura.ListaFacturas(13165856);

            if (facturas.Any())
            {
                foreach (Factura factura in facturas)
                {
                    string tipoDescargoValue = factura.tipo_especifico ? "Mensual" : factura.tipo_general ? "Trimestral" : "";
                    string dateOnly = factura.fecha_emision.ToString("yyyy-MM-dd");
                    //string dateOnly = factura.fecha_emision.ToString("d");

                    object[] rowData = {
                    factura.nombre_razon,
                    factura.nit_emisor,
                    factura.numero_factura,
                    factura.cod_autorizacion,
                    //factura.fecha_emision,
                    dateOnly,
                    factura.monto,
                    factura.monto_imponible,
                    factura.cod_control,
                    tipoDescargoValue
                };

                    dgvListaFacturas.Rows.Add(rowData);
                }
            }
            else { MessageBox.Show("No tienes facturas registradas."); }
        }
    }
}
