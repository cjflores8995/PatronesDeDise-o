using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryPattern_ConexionDb
{
    class CDBAdapterMongoDb : IDBAdapter
    {
        public void GetConnection()
        {
            Console.WriteLine("\nValidando credenciales MongoDB.");
            Thread.Sleep(1000);
            Console.WriteLine("Validando puertos tcp...");
            Thread.Sleep(1000);
            Console.WriteLine("Puerto 8804 ocupado.");
            Thread.Sleep(2000);
            Console.WriteLine("Validando puertos tcp...");
            Thread.Sleep(1000);
            Console.WriteLine("MongoDB levantada desde el puerto: 9874");
            Thread.Sleep(1500);
            Console.WriteLine("Validando credenciales...");
            Thread.Sleep(1000);
            Console.WriteLine("Haciendo ping de prueba. puerto: 9874....");
            Thread.Sleep(2000);
            Console.WriteLine("Conexión establecida correctamente.");
        }
    }
}
