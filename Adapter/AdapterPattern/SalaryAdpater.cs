using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class SalaryAdpater : SalaryCalaculator
    {
        private Employee _emp; 
        public double CalcSalary(MachineOperator _operator)
        {
            _emp = new Employee();
            _emp.BasicSalary = _operator.BasicSalary;
            return base.CalcSalary(_emp);
        }
    }
}
