using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_02_Animales
{
    abstract class ContinentFactory
    {
        public abstract Herbivoro CrearHerbivoro();
        public abstract Carnivoro CrearCarnivoro();
    }
}
