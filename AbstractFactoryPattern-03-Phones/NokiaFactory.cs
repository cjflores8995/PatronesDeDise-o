using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_03_Phones
{
    /// <summary>
    /// ConcreteFactory para implementar productos Nokia
    /// </summary>
    class NokiaFactory : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
