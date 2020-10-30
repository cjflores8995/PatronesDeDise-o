using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_01_Leccion01
{
    class FabricaQuimica : IFabrica
    {
        public IProductoLeche ObtenProductoLeche { get; private set; }
        public IProductoSaborizante ObtenSabor { get; private set; }

        public void CrearProductos()
        {
            Console.WriteLine("Estamos produciendo tu malteada...");

            ObtenProductoLeche = new LecheVaca();
            ObtenSabor = new SaborChocolate();
        }
    }
}
