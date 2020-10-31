using AbstractFactoryPattern_05_Muebleria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_05_Muebleria.Fabricas.MuebleriaModerna
{
    class Comedor : IComedor
    {
        public string Crear()
        {
            return "Comedor moderno con espacio para 8 personas";
        }
    }
}
