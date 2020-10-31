using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_04_Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear un programa que pueda crear familia de autos de alta gama (> $100000), gama media ( >= 20001 && < 100000) 
            y de gama baja ( <=20000) con las marcas Hyundai, Chevrolet, Mercedes-Benz, Mitsubishi
             */

            IVehiculoFactory hyundaiFactory = new HyundaiFactory();
            VehiculoClient vehiculo = new VehiculoClient(hyundaiFactory);

            Console.WriteLine("******* HYUNDAI *******");
            Console.WriteLine(vehiculo.GetGamaAlta());
            Console.WriteLine(vehiculo.GetGamaMedia());
            Console.WriteLine(vehiculo.GetGamaBaja());

            IVehiculoFactory chevroletFactory = new ChevroletFactory();
            vehiculo = new VehiculoClient(chevroletFactory);

            Console.WriteLine("\n");

            Console.WriteLine("****** CHEVROLET ******");
            Console.WriteLine(vehiculo.GetGamaAlta());
            Console.WriteLine(vehiculo.GetGamaMedia());
            Console.WriteLine(vehiculo.GetGamaBaja());

            Console.ReadKey();

        }
    }
}
