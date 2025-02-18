using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPatternSingleton
{
    class Counter
    {
        public int count = 0;
        private static Counter Instance = new Counter();
        private Counter()
        {

        }

        public static Counter GetInstance()
        {
            return Instance;
        }

        public void AddOne()
        {
            count++;
        }
    }
}
