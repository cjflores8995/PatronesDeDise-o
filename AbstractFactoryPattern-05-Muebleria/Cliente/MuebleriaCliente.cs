using AbstractFactoryPattern_05_Muebleria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_05_Muebleria.Cliente
{
    class MuebleriaCliente
    {
        public IComedor comedor;
        public ISilla silla;
        public IMesilla mesilla;
        public IMueble mueble;

        public MuebleriaCliente(IMuebleriaFactory factory)
        {
            this.comedor = factory.GetComedor();
            this.silla = factory.GetSilla();
            this.mesilla = factory.GetMesilla();
            this.mueble = factory.GetMueble();
        }
    }
}
