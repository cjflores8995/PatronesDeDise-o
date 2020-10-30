using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Facturas
{
    class CFacturaSinImpuestos: IFactura
    {
        public decimal ObtenerTotalFactura(decimal subTotal)
        {
            return Math.Round(subTotal, 2);
        }
    }
}
