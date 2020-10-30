using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class CAvion : IVehiculo
    {
        public void Caracteristicas()
        {
            Console.WriteLine("Felicitaciones un avión no todos lo pueden tener. Excelente!!!");
        }

        public void Acelerar()
        {
            Console.WriteLine("Empuja el acelerador, la palanca y oprime el voton que revisa el aleteo.");
        }

        public void Encender()
        {
            Console.WriteLine("Revias los controles, presiona los botones de encendido y acelera constantemente.");
        }

        public void Frenar()
        {
            Console.WriteLine("Revisa los controles, disminuye la velocidad y empieza a desacelerar.");
        }

        public void Girar()
        {
            Console.WriteLine("Revisa las alas y el radar, presiona el timon de dirección y empieza a girarlo.");
        }
    }
}
