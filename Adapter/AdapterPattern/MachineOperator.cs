using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class MachineOperator
    {
        public string Name { get; set; }

        public double BasicSalary { get; set; }

        public string ShiftCode { get; set; }
    }
}
