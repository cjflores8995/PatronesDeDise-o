using AbstractFactoryPattern_05_Muebleria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_05_Muebleria.Fabricas.MuebleriaModerna
{
    class Silla : ISilla
    {
        public string Crear()
        {
            return "Silla color green con toques modernos";
        }
    }
}
