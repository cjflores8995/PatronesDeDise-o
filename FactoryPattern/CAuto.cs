using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class CAuto : IVehiculo
    {
        public void Caracteristicas()
        {
            Console.WriteLine("Genial tu vehiculo es un automovil.");
        }

        public void Acelerar()
        {
            Console.WriteLine("Oprime el pedal del acelerador.");
        }

        public void Encender()
        {
            Console.WriteLine("Introduce la llave y girala.");
        }

        public void Frenar()
        {
            Console.WriteLine("Presiona el pedal de freno.");
        }

        public void Girar()
        {
            Console.WriteLine("Toma el volante y gíralo.");
        }
    }
}
