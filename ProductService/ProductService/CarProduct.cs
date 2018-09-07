using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    class CarProduct:IProduct
    {
        static Boolean isBooked = false;
        String name;
        int price;
        Logger log = Logger.getInstance();
        CarStrategy strategyobject = new CarStrategy();
        public CarProduct(String Pname,int Pprice)
        {
            log.LogMessage("Call to Car Product Constructor");
            name = Pname;
            price = strategyobject.GetFares(Pprice);
            log.LogMessage("Exiting Car Product Constructor");
        }
        public void Save(IRepository selection)
        {

            log.LogMessage("Call to Save Method of Car Product");
            selection.SaveTheProduct(name,price, isBooked,"Car");
            log.LogMessage("Exiting Save Method of Car Product");
        }
        public void Book(IRepository selection)
        {
            log.LogMessage("Call to Book Method of Car Product");
            if (isBooked == false)
                isBooked = true;
            selection.BookTheProduct(name, isBooked,"Car");
            log.LogMessage("Exiting Book Method Car Product");
        }
    }
}
