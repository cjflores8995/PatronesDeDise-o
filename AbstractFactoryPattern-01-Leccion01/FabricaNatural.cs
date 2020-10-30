using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_01_Leccion01
{
    class FabricaNatural : IFabrica
    {
        public IProductoLeche ObtenProductoLeche { get; private set; }
        public IProductoSaborizante ObtenSabor { get; private set; }

        public void CrearProductos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string seleccion;
            Console.WriteLine("Estamos creando tu bebida.");
            Console.Write("1) Almendras, 2) Coco: ");
            seleccion = Console.ReadLine();

            if (seleccion.Equals("1"))
                ObtenProductoLeche = new LecheAlmendras();
            else
                ObtenProductoLeche = new LecheCoco();

            ObtenProductoLeche.producir();

            Console.WriteLine("\nAhora extraemos el sabor...");
            ObtenSabor = new VainillaNatural();
            ObtenSabor.obtener();
        }
    }
}
