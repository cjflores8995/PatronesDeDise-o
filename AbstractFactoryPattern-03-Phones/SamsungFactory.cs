using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_03_Phones
{
    /// <summary>
    /// ConcreteFactory fabrica concreta para crear telefonos Samsung
    /// </summary>
    class SamsungFactory : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
