using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFactura.Services
{
    internal class Factura
    {
        private long nit_usuario { get; set; }
        private long nit_emisor { get; set; }
        private int numero_factura { get; set; }
        private string cod_autorizacion { get; set; }
        private string nombre_razon { get; set; }
        private DateTime fecha_emision { get; set; }
        private decimal monto { get; set; }
        private decimal monto_imponible { get; set; }
        private string cod_control {  get; set; }
        private bool tipo_especifico { get; set; }
        private bool tipo_general { get; set; }

        public Factura(long nit_usuario, long nit_emisor, int numero_factura, string cod_autorizacion, string nombre_razon, DateTime fecha_emision, decimal monto, decimal monto_imponible, string cod_control, bool tipo_especifico, bool tipo_general)
        {
            this.nit_usuario = nit_usuario;
            this.nit_emisor = nit_emisor;
            this.numero_factura = numero_factura;
            this.cod_autorizacion = cod_autorizacion;
            this.nombre_razon = nombre_razon;
            this.fecha_emision = fecha_emision;
            this.monto = monto;
            this.monto_imponible = monto_imponible;
            this.cod_control = cod_control;
            this.tipo_especifico = tipo_especifico;
            this.tipo_general = tipo_general;
        }
        public Factura() { }
    }
}
