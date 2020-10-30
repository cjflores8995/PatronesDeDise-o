using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Facturas
{
    public interface IFactura
    {
        decimal ObtenerTotalFactura(decimal subTotal);
    }
}
