using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    class DatabaseType
    {
        public IRepository GetDatabaseType(String databasename)
        {
            Logger log = Logger.getInstance();
            log.LogMessage("Call to GetDatabaseType Method");
            IRepository productInstance;
            switch (databasename)
            {
                case "File Handling":log.LogMessage("Entered the File Handling Case");
                                     productInstance = new FileHandling();
                                     log.LogMessage("Exiting the GetDatabaseType Method");
                                     return productInstance;
                case "Sql Server":   log.LogMessage("Entered the Sql Server Case");
                                     productInstance = new SqlDatabase();
                                     log.LogMessage("Exiting the GetDatabaseType Method");
                                     return productInstance;
                default:             log.LogMessage("Entered Default Case");
                                     log.LogMessage("Throwing an Exception");
                                     throw new Exception("Invalid Choice");
            }
        }
    }
}
