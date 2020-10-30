using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Facturas
{
    public static class CFacturaCreator
    {
        public static IFactura Creator(int tipoContribuyente)
        {
            IFactura factura = null;

            try
            {
                switch (tipoContribuyente)
                {
                    case (int)CommonEnums.TipoContribuyente.CONTRIBUYENTE:
                        factura = new CFacturaConImpuestos();
                        break;
                    case (int)CommonEnums.TipoContribuyente.CONTRIBUYENTE_MANABI:
                        factura = new CFacturaManabi();
                        break;
                    case (int)CommonEnums.TipoContribuyente.EXONERADO_DE_IMPUESTOS:
                        factura = new CFacturaSinImpuestos();
                        break;
                    default:
                        factura = null;
                        break;
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }

            return factura;
        }
    }
}
