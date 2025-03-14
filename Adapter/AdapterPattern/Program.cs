namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            MachineOperator machineOperator = new MachineOperator();

            machineOperator.BasicSalary = 1200;
            emp.Name = "test"; emp.BasicSalary = 1000;

            SalaryAdpater calaculator = new SalaryAdpater();

            var salary = calaculator.CalcSalary(machineOperator);
            Console.WriteLine(salary.ToString());


        }
    }
}
