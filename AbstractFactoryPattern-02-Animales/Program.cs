using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_02_Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalesDelMundo mundo = new AnimalesDelMundo(africa);
            mundo.EjecutarCadenaAlimenticia();

            ContinentFactory america = new AmericaFactory();
            mundo = new AnimalesDelMundo(america);
            mundo.EjecutarCadenaAlimenticia();

            Console.Read();
        }
    }
}
