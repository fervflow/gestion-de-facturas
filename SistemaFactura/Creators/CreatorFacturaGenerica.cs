using SistemaFactura.Models;
using SistemaFactura.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFactura.Creators
{
    internal class CreatorFacturaGenerica : GestionarFactura
    {
        public override IFactura Create(long nit_usuario, long nit_emisor, int numero_factura, string cod_autorizacion,
            string nombre_razon, DateTime fecha_emision, decimal monto, decimal monto_imponible,
            string cod_control, bool tipo_especifico, bool tipo_general)
        {
            return new FacturaGenerica(nit_usuario, nit_emisor, numero_factura,
                    cod_autorizacion, nombre_razon, fecha_emision, monto,
                    monto_imponible, cod_control, tipo_especifico, tipo_general);
        }
    }
}
