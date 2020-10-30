using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("¿Cuanto dinero tienes para tu vehiculo?");
            dinero = Convert.ToInt32(Console.ReadLine());

            vehiculo = CCreador.MetodoFabrica(dinero);


            vehiculo.Caracteristicas();
            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Girar();
            vehiculo.Frenar();

            Console.Read();
        }
    }
}
