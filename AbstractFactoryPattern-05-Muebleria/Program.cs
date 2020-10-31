using AbstractFactoryPattern_05_Muebleria.Cliente;
using AbstractFactoryPattern_05_Muebleria.Fabricas.MuebleriaModerna;
using AbstractFactoryPattern_05_Muebleria.Fabricas.MuebleriaVictoriana;
using AbstractFactoryPattern_05_Muebleria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_05_Muebleria
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear mediante abstract factory distintas familias de muebles que contengasn como productos:
             - comedor
             - mesilla
             - mueble
             - silla
            crear 2 familias que puedan ser implementadas las cuales seran
             - muebleria moderna
             - muebleria victoriana
             */

            string mensaje = string.Empty;
            string opcionMuebleria = string.Empty;
            MuebleriaCliente muebleria;

            Console.Write("Selecciona una muebleria\n1) Moderna, 2) Victoriana: ");
            opcionMuebleria = Console.ReadLine();

            if (opcionMuebleria.Equals("1"))
            {
                mensaje = "\n******** MUEBLERIA MODERNA ********\n";
                muebleria = new MuebleriaCliente(new MuebleriaModernaFactory());
            } 
            else
            {
                mensaje = "\n****** MUEBLERIA VICTORIANA *******\n";
                muebleria = new MuebleriaCliente(new MuebleriaVictorianaFactory());
            }

            Console.WriteLine(mensaje);

            Console.WriteLine(muebleria.comedor.Crear());
            Console.WriteLine(muebleria.mesilla.Crear());
            Console.WriteLine(muebleria.mueble.Crear());
            Console.WriteLine(muebleria.silla.Crear());

            Console.ReadKey();
        }
    }
}
