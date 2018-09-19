using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    class CarStrategy:IStrategy
    {
        Logger log = Logger.getInstance();
        public int GetFares(int price)
        {
            log.LogMessage("Call to GetFares Method of Car Strategy");
            int fares = price + price * 20 / 100;
            log.LogMessage("Exiting the GetFares Method");
            return fares;
        }
    }
}
