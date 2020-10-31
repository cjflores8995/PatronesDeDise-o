using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_02_Animales
{
    class AnimalesDelMundo
    {
        private Herbivoro herbivoro;
        private Carnivoro carnivoro;

        public AnimalesDelMundo(ContinentFactory factory)
        {
            carnivoro = factory.CrearCarnivoro();
            herbivoro = factory.CrearHerbivoro();
        }

        public void EjecutarCadenaAlimenticia()
        {
            carnivoro.Come(herbivoro);
        }
    }
}
