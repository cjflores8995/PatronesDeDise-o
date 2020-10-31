using AbstractFactoryPattern_05_Muebleria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_05_Muebleria.Fabricas.MuebleriaVictoriana
{
    class Comedor : IComedor
    {
        public string Crear()
        {
            return "Comedor victoriano con toques del siglo 17 y estilo impecable";
        }
    }
}
