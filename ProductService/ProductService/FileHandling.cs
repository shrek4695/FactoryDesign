using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProductService
{
    class FileHandling:IRepository
    {
        public void SaveTheProduct(String name,int price, Boolean book,String producttype)
        {
            FileStream fs = new FileStream("c:\\Saving.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Product Type=" + producttype);
            sw.WriteLine("Product Name=" + name);
            sw.WriteLine("Product Price=" + price);
            sw.WriteLine("Booked=" + book);
            sw.Flush();
            fs.Close();
        }
        public void BookTheProduct(String name,Boolean book,String producttype)
        {
            FileStream fs = new FileStream("c:\\Saving.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Product Type=" + producttype);
            sw.WriteLine("Product Name=" + name);
            sw.WriteLine("Booked=" + book);
            sw.Flush();
            fs.Close();
        }
    }
}
