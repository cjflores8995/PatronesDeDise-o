using AbstractFactoryPattern_05_Muebleria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_05_Muebleria.Fabricas.MuebleriaVictoriana
{
    class Mesilla : IMesilla
    {
        public string Crear()
        {
            return "Mesilla victoriana con toque para 2 personas del siglo 15";
        }
    }
}
