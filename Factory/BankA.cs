﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class BankA:IBank
    {
        public string withdraw()
        {
            return "your request in handling by BankA";
        }
    }
}
