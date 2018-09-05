using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class CarProduct:IProduct
    {
        public String GetTypeofProduct()
        {
            return "Car";
        }
        public void Save()
        {
            Console.WriteLine("Saving Car Product");
        }
        public void Book()
        {
            Console.WriteLine("Booking Car Product");
        }
    }
}
