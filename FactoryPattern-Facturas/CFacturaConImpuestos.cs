﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FactoryPattern_Facturas
{
    class CFacturaConImpuestos: IFactura
    {
        public decimal ObtenerTotalFactura(decimal subTotal)
        {
            return Math.Round(subTotal + (subTotal * Convert.ToInt32(ConfigurationManager.AppSettings["IVA"].ToString()) / 100), 2);
        }
    }
}
