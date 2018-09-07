using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    public interface IRepository
    {
        void SaveTheProduct(String name, int Price, Boolean Book,String producttype);
        void BookTheProduct(String Message, Boolean Book,String producttype);
    }
}
