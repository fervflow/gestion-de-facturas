using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFactura.Services
{
    internal class Factura
    {
        public long nit_usuario { get; set; }
        public long nit_emisor { get; set; }
        public int numero_factura { get; set; }
        public string cod_autorizacion { get; set; }
        public string nombre_razon { get; set; }
        public DateTime fecha_emision { get; set; }
        public decimal monto { get; set; }
        public decimal monto_imponible { get; set; }
        public string cod_control { get; set; }
        public bool tipo_especifico { get; set; }
        public bool tipo_general { get; set; }

        public Factura(long nit_usuario, long nit_emisor, int numero_factura, string cod_autorizacion,
            string nombre_razon, DateTime fecha_emision, decimal monto, decimal monto_imponible,
            string cod_control, bool tipo_especifico, bool tipo_general)
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
    }
}
