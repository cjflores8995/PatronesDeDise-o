using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_03_Phones
{
    /// <summary>
    /// Clase Client
    /// </summary>
    class MobileClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public MobileClient(IMobilePhone factory)
        {
            this.smartPhone = factory.GetSmartPhone();
            this.normalPhone = factory.GetNormalPhone();
        }

        public string GetSmartPhoneMobileDetails()
        {
            return this.smartPhone.GetModelDetails();
        }

        public string GetNormalPhoneMobileDetails()
        {
            return this.normalPhone.GetModelDetails();
        }
    }
}
