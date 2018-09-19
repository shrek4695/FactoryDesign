using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    public interface IProduct
    {
        void Save(IRepository selection);
        void Book(IRepository selection);

    }
}
