﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    interface IStrategy
    {
        int GetFares(int Price);
    }
}
