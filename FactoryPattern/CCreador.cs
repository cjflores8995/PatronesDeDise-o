using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class CCreador
    {
        public static IVehiculo MetodoFabrica(int pDinero)
        {
            IVehiculo temp = null;

            try
            {
                //Seleccionamos el tipo de instancia segun nuestras reglas
                if (pDinero > 10000000)
                    temp = new CAvion();
                else if (pDinero > 200000)
                    temp = new CAuto();
                else
                    temp = new CBici();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return temp;
        }
    }
}
