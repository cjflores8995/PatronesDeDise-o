using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_02_Animales
{
    class AfricaFactory : ContinentFactory
    {
        public override Carnivoro CrearCarnivoro()
        {
            return new Leon();
        }

        public override Herbivoro CrearHerbivoro()
        {
            return new NiuSalvaje();
        }
    }
}
