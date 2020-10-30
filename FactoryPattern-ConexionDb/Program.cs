using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_ConexionDb
{
    class Program
    {
        static void Main(string[] args)
        {
            string adaptador = ConfigurationManager.AppSettings["adaptador"];
            IDBAdapter dBAdapter = DbFactory.Create(adaptador);

            dBAdapter.GetConnection();

            var adaptadorMySQL = DbFactory.Create("mysql");
            adaptadorMySQL.GetConnection();

            var adaptadorOracle = DbFactory.Create("ORACLE");
            adaptadorOracle.GetConnection();

            var adaptadorMongoDB = DbFactory.Create("mongodb");
            adaptadorMongoDB.GetConnection();

            Console.Read();

        }
    }
}
