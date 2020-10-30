using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_01_Leccion01
{
    class LecheAlmendras : IProductoLeche
    {
        public string obtenDatos()
        {
            return "Leche orgánica de almendra,. 250ml";
        }

        public void producir()
        {
            Console.WriteLine("Procesar las almendras.");
        }
    }
}
