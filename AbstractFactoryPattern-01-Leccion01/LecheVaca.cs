using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_01_Leccion01
{
    class LecheVaca : IProductoLeche
    {
        public string obtenDatos()
        {
            return "Leche de vaca, 250ml.";
        }

        public void producir()
        {
            Console.WriteLine("Ordeñar vaca en la granja.");
        }
    }
}
