using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_01_Leccion01
{
    class LecheCoco : IProductoLeche
    {
        public string obtenDatos()
        {
            return "Leche de coco natural, 250ml.";
        }

        public void producir()
        {
            Console.WriteLine("Buscamos los cocos.");
        }
    }
}
