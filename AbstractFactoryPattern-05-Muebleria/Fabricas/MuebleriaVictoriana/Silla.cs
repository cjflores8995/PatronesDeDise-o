using AbstractFactoryPattern_05_Muebleria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_05_Muebleria.Fabricas.MuebleriaVictoriana
{
    class Silla : ISilla
    {
        public string Crear()
        {
            return "Silla victoriana construida con madera fina del norte de Kingston";
        }
    }
}
