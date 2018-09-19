using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Logger log = Logger.getInstance();
                log.LogMessage("Entered Main Method");
                Console.WriteLine("Enter Type of Product");
                Console.WriteLine("Air");
                Console.WriteLine("Car");
                Console.WriteLine("Activity");
                Console.WriteLine("Hotel");
                String desc = Console.ReadLine();
                Console.WriteLine("Enter Name of Product");
                String name = Console.ReadLine();
                Console.WriteLine("Enter Price of Product");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Type of Database");
                Console.WriteLine("File Handling");
                Console.WriteLine("Sql Server");
                String databasename = Console.ReadLine();
                DatabaseType obj = new DatabaseType();
                IRepository databasetype = obj.GetDatabaseType(databasename);
                ProductType ob = new ProductType();
                IProduct prod = ob.GetProduct(desc, name,price);
                prod.Save(databasetype);
                prod.Book(databasetype);
                Console.ReadKey();
                log.LogMessage("Exiting the Main Method");
            }
            catch (Exception e)
            {
                Logger log = Logger.getInstance();
                log.LogMessage("Entered catch block");
                Console.WriteLine(e.Message);
                Console.ReadKey();
                log.LogMessage("Exiting the catch block");
            }
        }
    }
}
