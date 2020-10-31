using AbstractFactoryPattern_02_Vehiculos.Class;
using AbstractFactoryPattern_02_Vehiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_02_Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaDeVehiculos factory;
            FabricaBuses buses = new FabricaBuses();
            string option;

            Console.Write("Selecciona un vehiculo: \n 1) Bus, 2) Buseta, 3) Taxi: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    factory = FabricaDeVehiculos.CrearFabricaDeVehiculo(buses);
                    break;
            }

            Console.Read();
        }
    }
}
