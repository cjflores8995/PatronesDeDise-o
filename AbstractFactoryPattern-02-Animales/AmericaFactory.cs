using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_02_Animales
{
    class AmericaFactory : ContinentFactory
    {
        public override Carnivoro CrearCarnivoro()
        {
            return new Lobo();
        }

        public override Herbivoro CrearHerbivoro()
        {
            return new Bison();
        }
    }
}
