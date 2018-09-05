using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class ActivityProduct:IProduct
    {
        public String GetTypeofProduct()
        {
            return "Activity";
        }
        public void Save()
        {
            Console.WriteLine("Saving Activity Product");
        }
        public void Book()
        {
            Console.WriteLine("Booking Car Product");
        }
    }
}
