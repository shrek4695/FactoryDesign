using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class AirProduct:IProduct
    {
        public String GetTypeofProduct()
        {
            return "Air";
        }
        public void Save()
        {
            Console.WriteLine("Saving Air Product");
        }
        public void Book()
        {
            Console.WriteLine("Booking Air Product");
        }
    }
}
