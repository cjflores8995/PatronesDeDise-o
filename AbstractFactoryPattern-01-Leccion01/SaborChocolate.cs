using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_01_Leccion01
{
    class SaborChocolate : IProductoSaborizante
    {
        public string informacion()
        {
            return "Sabor a chocolate";
        }

        public void obtener()
        {
            Console.WriteLine("Se produce C7H8N4O2");
        }
    }
}
