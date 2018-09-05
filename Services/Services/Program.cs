using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class Program
    {
        public static void Main()
        {
            try
            {
                String desc = Console.ReadLine();
                ProductType ob = new ProductType();
                IProduct prod = ob.GetProduct(desc);
                String producttype = prod.GetTypeofProduct();
                prod.Book();
                prod.Save();
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
