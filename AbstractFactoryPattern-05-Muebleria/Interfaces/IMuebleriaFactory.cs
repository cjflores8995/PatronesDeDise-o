using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_05_Muebleria.Interfaces
{
    interface IMuebleriaFactory
    {
        IComedor GetComedor();
        IMesilla GetMesilla();
        IMueble GetMueble();
        ISilla GetSilla();
    }
}
