using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryPattern_ConexionDb
{
    class CDBAdapterSQLServer : IDBAdapter
    {
        public void GetConnection()
        {
            Console.WriteLine("\nValidando tipo de conexión SQL Server.");
            Thread.Sleep(1000);
            Console.WriteLine("Conexión mediante autenticación de Windows.");
            Thread.Sleep(1000);
            Console.WriteLine("Validando usuario y contraseña...");
            Thread.Sleep(300);
            Console.WriteLine("Realizando ping de conexión...");
            Thread.Sleep(1500);
            Console.WriteLine("La conexión SQL sServer se ha realizado correctamente.");
        }
    }
}
