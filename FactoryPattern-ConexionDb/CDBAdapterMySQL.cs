using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryPattern_ConexionDb
{
    class CDBAdapterMySQL: IDBAdapter
    {
        public void GetConnection()
        {
            Console.WriteLine("\nLevantando el puerto 3306 de MySQL.");
            Thread.Sleep(1000);
            Console.WriteLine("Intentando conectar...");
            Thread.Sleep(300);
            Console.WriteLine("Validando credenciales...");
            Thread.Sleep(1500);
            Console.WriteLine("Conexión a MySQL exitosa.");
        }
    }
}
