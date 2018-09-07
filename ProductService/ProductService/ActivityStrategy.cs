using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    class ActivityStrategy:IStrategy
    {
        Logger log = Logger.getInstance();
        public int GetFares(int price)
        {
            log.LogMessage("Call to GetFares Method of Activity Strategy");
            int fares = price + price * 10 / 100;
            log.LogMessage("Exiting GetFares Method");
            return fares;
        }
    }
}
