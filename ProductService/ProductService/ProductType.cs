using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    public class ProductType
    {
        public IProduct GetProduct(String desc, String name,int price)
        {
            Logger log = Logger.getInstance();
            log.LogMessage("Call to GetProduct Method");
            IProduct productInstance;
            switch (desc)
            {
                case "Car":     log.LogMessage("Entered Car Case");
                                productInstance = new CarProduct(name,price);
                                log.LogMessage("Exiting the GetProduct Method");
                                return productInstance;
                case "Activity":log.LogMessage("Entered Activity Case");
                                productInstance = new ActivityProduct(name,price);
                                log.LogMessage("Exiting the GetProduct Method");
                                return productInstance;
                case "Hotel":   log.LogMessage("Entered Hotel Case");
                                productInstance = new HotelProduct(name,price);
                                log.LogMessage("Exiting the GetProduct Method");
                                return productInstance;
                case "Air":     log.LogMessage("Entered Air Case");
                                productInstance = new AirProduct(name,price);
                                log.LogMessage("Exiting the GetProduct Method");
                                return productInstance;
                default:        log.LogMessage("Entered Default Case");
                                log.LogMessage("Throwing an Exception");
                                throw new Exception("Invalid Choice");
            }
        }
    }
}
