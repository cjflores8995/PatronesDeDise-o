using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_ConexionDb
{
    public static class DbFactory
    {
        public static IDBAdapter Create(string adapter)
        {
            IDBAdapter dBAdapter = null;
            adapter = adapter.ToLower().Trim();

            try
            {
                switch (adapter)
                {
                    case "oracle":
                        dBAdapter = new CDBAdapterOracle();
                        break;
                    case "mysql":
                        dBAdapter = new CDBAdapterMySQL();
                        break;
                    case "sqlserver":
                        dBAdapter = new CDBAdapterSQLServer();
                        break;
                    case "mongodb":
                        dBAdapter = new CDBAdapterMongoDb();
                        break;
                    default:
                        dBAdapter = null;
                        break;
                }
            } 
            catch(Exception ex)
            {
                ex.ToString();
            }

            return dBAdapter;
        } 
    }
}
