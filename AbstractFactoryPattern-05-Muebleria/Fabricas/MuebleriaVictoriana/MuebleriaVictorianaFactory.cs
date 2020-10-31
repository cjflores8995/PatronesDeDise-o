using AbstractFactoryPattern_05_Muebleria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_05_Muebleria.Fabricas.MuebleriaVictoriana
{
    class MuebleriaVictorianaFactory : IMuebleriaFactory
    {
        public IComedor GetComedor()
        {
            return new Comedor();
        }

        public IMesilla GetMesilla()
        {
            return new Mesilla();
        }

        public IMueble GetMueble()
        {
            return new Mueble();
        }

        public ISilla GetSilla()
        {
            return new Silla();
        }
    }
}
