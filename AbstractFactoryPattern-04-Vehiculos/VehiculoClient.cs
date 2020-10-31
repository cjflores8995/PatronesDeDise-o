using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_04_Vehiculos
{
    public class VehiculoClient
    {
        IGamaAlta gamaAlta;
        IGamaMedia gamaMedia;
        IGamaBaja gamaBaja;

        public VehiculoClient(IVehiculoFactory factory)
        {
            this.gamaAlta = factory.GetGamaAlta();
            this.gamaMedia = factory.GetGamaMedia();
            this.gamaBaja = factory.GetGamaBaja();
        }

        public string GetGamaAlta()
        {
            return this.gamaAlta.GetDetails();
        }

        public string GetGamaMedia()
        {
            return this.gamaMedia.GetDetails();
        }

        public string GetGamaBaja()
        {
            return this.gamaBaja.GetDetails();
        }


    }
}
