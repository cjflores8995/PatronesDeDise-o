using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_04_Vehiculos
{
    abstract class Vehiculo
    {
        public string Gama { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Descripcion { get; set; }

        public string GetDetails()
        {
            return $"GAMA: {this.Gama}\nNOMBRE: {this.Nombre}\nPRECIO: {this.Precio}\nDESCRIPCIÓN: {this.Descripcion}\n";
        }
    }
}
