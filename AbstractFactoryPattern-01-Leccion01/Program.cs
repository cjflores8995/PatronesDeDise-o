using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_01_Leccion01
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabrica miFabrica = new FabricaQuimica();

            miFabrica.CrearProductos();

            IProductoLeche miLeche = miFabrica.ObtenProductoLeche;
            IProductoSaborizante miSabor = miFabrica.ObtenSabor;

            miLeche.producir();
            miSabor.obtener();

            Console.WriteLine($"Mi malteada es de {miLeche.obtenDatos()} y {miSabor.informacion()}");
            Console.WriteLine("------");


            miFabrica = new FabricaNatural();
            miFabrica.CrearProductos();

            miLeche = miFabrica.ObtenProductoLeche;
            miSabor = miFabrica.ObtenSabor;

            Console.WriteLine($"Mi malteada es de {miLeche.obtenDatos()} y {miSabor.informacion()}");

            Console.Read();
        }
    }
}
