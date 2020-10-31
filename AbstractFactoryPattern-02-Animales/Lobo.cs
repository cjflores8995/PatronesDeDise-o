using System;

namespace AbstractFactoryPattern_02_Animales
{
    class Lobo : Carnivoro
    {
        public override void Come(Herbivoro h)
        {
            Console.WriteLine(this.GetType().Name + " come " + h.GetType().Name);
        }
    }
}