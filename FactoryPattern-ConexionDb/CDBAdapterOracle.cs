using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryPattern_ConexionDb
{
    class CDBAdapterOracle : IDBAdapter
    {
        public void GetConnection()
        {
            Console.WriteLine("\nObteniendo cadena de conexión Oracle...");
            Thread.Sleep(1000);
            Console.WriteLine("Cadena de conexión obtenida exitosamente");
            Thread.Sleep(300);
            Console.WriteLine("Conectando a Oracle...");
            Thread.Sleep(1500);
            Console.WriteLine("Conexión realizada correctamente.");
        }
    }
}
