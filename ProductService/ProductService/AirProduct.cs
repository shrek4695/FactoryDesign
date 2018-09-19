using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    class AirProduct:IProduct
    {
        static Boolean isBooked = false;
        String name;
        int price;
        Logger log = Logger.getInstance();
        AirStrategy strategyobject = new AirStrategy();
        public AirProduct(String Pname,int Pprice)
        {
            log.LogMessage("Call to Air Product Constructor");
            name = Pname;
            price = strategyobject.GetFares(Pprice);
            log.LogMessage("Exiting Air Product Constructor");
        }
        public void Save(IRepository selection)
        {
            log.LogMessage("Call to Save Method of Air Product");
            selection.SaveTheProduct(name,price, isBooked,"Air");
            log.LogMessage("Exiting Save Method of Air Product");
        }
        public void Book(IRepository selection)
        {
            log.LogMessage("Call to Book Method of Air Product");
            if (isBooked == false)
                isBooked = true;
            selection.BookTheProduct(name, isBooked,"Air");
            log.LogMessage("Exiting Book Method Air Product");
        }
    }
}
