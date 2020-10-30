using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class CBici : IVehiculo
    {
        public void Caracteristicas()
        {
            Console.WriteLine("Bien, haz empezado con una bicicleta, algo es algo!");
        }

        public void Acelerar()
        {
            Console.WriteLine("Pedalea fuerte para acelerar.");
        }

        public void Encender()
        {
            Console.WriteLine("La bici no necesita encendido.");
        }

        public void Frenar()
        {
            Console.WriteLine("Presiona el freno trasero primero.");
        }

        public void Girar()
        {
            Console.WriteLine("Usa el manubrio.");
        }
    }
}
