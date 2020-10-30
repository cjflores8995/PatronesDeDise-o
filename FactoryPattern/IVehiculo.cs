using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    interface IVehiculo
    {
        void Caracteristicas();
        void Acelerar();
        void Encender();
        void Frenar();
        void Girar();
    }
}
