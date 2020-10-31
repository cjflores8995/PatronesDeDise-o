using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_04_Vehiculos
{
    class ChevroletFactory : IVehiculoFactory
    {
        public IGamaAlta GetGamaAlta()
        {
            return new ChevroletTahoe();
        }

        public IGamaBaja GetGamaBaja()
        {
            return new ChevroletSparkGT();
        }

        public IGamaMedia GetGamaMedia()
        {
            return new ChevroletCaptiva();
        }
    }
}
