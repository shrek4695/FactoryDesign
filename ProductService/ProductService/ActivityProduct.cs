using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    class ActivityProduct:IProduct
    {
        static Boolean isBooked = false;
        String name;
        int price;
        Logger log = Logger.getInstance();
        ActivityStrategy strategyobject = new ActivityStrategy();
        public ActivityProduct(String Pname,int Pprice)
        {
            log.LogMessage("Call to Activity Product Constructor");
            name = Pname;
            price = strategyobject.GetFares(Pprice);
            log.LogMessage("Exiting Activity Product Constructor");
        }
        public void Save(IRepository selection)
        {
            log.LogMessage("Call to Save Method of Activity Product");
            selection.SaveTheProduct(name, price,isBooked,"Activity");
            log.LogMessage("Exiting Save Method of Activity Product");
        }
        public void Book(IRepository selection)
        {
            log.LogMessage("Call to Book Method of Activity Product");
            if (isBooked == false)
                isBooked = true;
            selection.BookTheProduct(name, isBooked,"Activity");
            log.LogMessage("Exiting Book Method of Activity Product");
        }

    }
}
