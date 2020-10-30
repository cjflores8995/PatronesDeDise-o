﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_01_Leccion01
{
    class VainillaNatural : IProductoSaborizante
    {
        public string informacion()
        {
            return "Extracto natural de vainilla";
        }

        public void obtener()
        {
            Console.WriteLine("Se extrae de las vainas.");
        }
    }
}
