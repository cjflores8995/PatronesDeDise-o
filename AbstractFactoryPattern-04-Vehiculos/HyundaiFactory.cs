using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_04_Vehiculos
{
    class HyundaiFactory : IVehiculoFactory
    {
        public IGamaAlta GetGamaAlta()
        {
            return new HyundaiVeracruz();
        }

        public IGamaBaja GetGamaBaja()
        {
            return new HyundaiAccent();
        }

        public IGamaMedia GetGamaMedia()
        {
            return new HyundaiSantaFe();
        }
    }
}
