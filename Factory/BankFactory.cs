using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class BankFactory : IBankFactory
    {
        public IBank GetBank(string BankCode)
        {
            switch(BankCode)
            {
                case "123456": return new BankA();break;
                case "111111": return new BankB();break;
            }
            return null;
        }
    }
}
