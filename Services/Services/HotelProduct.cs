using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class HotelProduct:IProduct
    {
        public String GetTypeofProduct()
        {
            return "Hotel";
        }
        public void Save()
        {
            Console.WriteLine("Saving Hotel Product");
        }
        public void Book()
        {
            Console.WriteLine("Booking Hotel Product");
        }
    }
}
