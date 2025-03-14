using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class SalaryCalaculator
    {
        public double CalcSalary(Employee emp) => emp.BasicSalary * 1.5;
    }
}
