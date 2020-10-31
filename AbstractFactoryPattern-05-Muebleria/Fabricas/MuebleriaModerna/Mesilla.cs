using AbstractFactoryPattern_05_Muebleria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_05_Muebleria.Fabricas.MuebleriaModerna
{
    class Mesilla : IMesilla
    {
        public string Crear()
        {
            return "Mesilla moderna con toques modernos";
        }
    }
}
