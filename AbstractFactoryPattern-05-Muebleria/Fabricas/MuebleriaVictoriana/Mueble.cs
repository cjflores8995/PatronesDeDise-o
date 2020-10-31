using AbstractFactoryPattern_05_Muebleria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_05_Muebleria.Fabricas.MuebleriaVictoriana
{
    class Mueble : IMueble
    {
        public string Crear()
        {
            return "Juego de muebles para 12 personas ya que en la epoca victoriana eran muchas personas";
        }
    }
}
