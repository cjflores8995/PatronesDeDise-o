using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_03_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            IMobilePhone nokiaFactory = new NokiaFactory();
            MobileClient nokiaClient = new MobileClient(nokiaFactory);

            Console.WriteLine("********* NOKIA **********");
            Console.WriteLine(nokiaClient.GetSmartPhoneMobileDetails());
            Console.WriteLine(nokiaClient.GetNormalPhoneMobileDetails());

            IMobilePhone samsungMFactory = new SamsungFactory();
            MobileClient samsungClient = new MobileClient(samsungMFactory);

            Console.WriteLine("******* SAMSUNG **********");
            Console.WriteLine(samsungClient.GetSmartPhoneMobileDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneMobileDetails());

            Console.ReadKey();
        }
    }
}
