using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class ProductType
    {
        public IProduct GetProduct(String desc)
        {
            switch(desc)
            {
                case "Car":return new CarProduct();
                case "Activity":return new ActivityProduct();
                case "Hotel":return new HotelProduct();
                case "Air":return new AirProduct();
                default: throw new Exception("Invalid Choice");

            }
        }
    }
}
