namespace DesginPatternSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter C1 = Counter.GetInstance();
            Counter C2 = Counter.GetInstance();

            C1.AddOne();
            Console.WriteLine("Counter 1 = " + C1.count.ToString());

            C2.AddOne();
            Console.WriteLine("Counter 2 = " + C2.count.ToString());

            Console.WriteLine();

            C1.AddOne();
            Console.WriteLine("Counter 1 = " + C1.count.ToString());
            Console.WriteLine("Counter 2 = " + C2.count.ToString());
            Console.ReadKey();


        }
    }
}
