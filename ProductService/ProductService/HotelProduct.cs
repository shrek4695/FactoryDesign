using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    class HotelProduct:IProduct
    {
        static Boolean isBooked = false;
        String name;
        int price;
        Logger log = Logger.getInstance();
        HotelStrategy strategyobject = new HotelStrategy();
        public HotelProduct(String Pname,int Pprice)
        {
            log.LogMessage("Call to Hotel Product Constructor");
            name = Pname;
            price = strategyobject.GetFares(Pprice);
            log.LogMessage("Exiting Hotel Product Constructor");
        }
        public void Save(IRepository selection)
        {
            log.LogMessage("Call to Save Method of Hotel Product");
            selection.SaveTheProduct(name,price,isBooked,"Hotel");
            log.LogMessage("Exiting Save Method of Hotel Product");
        }
        public void Book(IRepository selection)
        {
            log.LogMessage("Call to Book Method of Hotel Product");
            if (isBooked == false)
                isBooked = true;
            selection.BookTheProduct(name, isBooked, "Hotel");
            log.LogMessage("Exiting Book Method Hotel Product");
        }
    }
}
