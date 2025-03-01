using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class BankB:IBank
    {
        public string withdraw()
        {
            return "your request in handling by BankB";
        }
    }
}
