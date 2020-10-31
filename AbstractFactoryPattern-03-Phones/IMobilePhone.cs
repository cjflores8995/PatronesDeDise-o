using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_03_Phones
{
    /// <summary>
    /// La interface AbstractFactory
    /// </summary>
    interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
