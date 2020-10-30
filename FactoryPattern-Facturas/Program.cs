using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Facturas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear un programa que reciba como entrada el subtotal del valor de una factura
            dependiendo de si el cliente es contribuyente o no calcular el iva y valores totales de la factura
            Utilizar el patron Factory para este ejercicio.
             */


            IFactura factura;
            decimal subTotal;

            Console.Write("¿Eres contriyutente de impuestos? si/no/ma: ");
            string esContribuyente = Console.ReadLine().ToLower();

            if (esContribuyente.Equals("si"))
                factura = CFacturaCreator.Creator((int)CommonEnums.TipoContribuyente.CONTRIBUYENTE);
            else if(esContribuyente.Equals("ma"))
                factura = CFacturaCreator.Creator((int)CommonEnums.TipoContribuyente.CONTRIBUYENTE_MANABI);
            else
                factura = CFacturaCreator.Creator((int)CommonEnums.TipoContribuyente.EXONERADO_DE_IMPUESTOS);

            Console.Write("Ingresa el sub total de la factura: ");
            subTotal = (decimal)Console.ReadLine().CustomParse();

            Console.WriteLine("\nDetalle de factura\n");
            Console.WriteLine($"SUBTOTAL\t\t{subTotal.ToString()}");
            Console.WriteLine($"TOTAL\t\t\t{factura.ObtenerTotalFactura(subTotal).ToString()}");

            Console.Read();
        }
    }

    public  static class CustomDecimal
    {
        public static decimal? CustomParse(this string incomingValue)
        {
            decimal val;
            if (!decimal.TryParse(incomingValue.Replace(",", "").Replace(".", ""), NumberStyles.Number, CultureInfo.InvariantCulture, out val))
                return null;
            return val / 100;
        }
    }
}
