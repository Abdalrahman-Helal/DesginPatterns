namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string CardNumber, BankCode;
            BankFactory bankFactory = new BankFactory();
            Console.WriteLine("Enter your card numebr ");
            CardNumber = Console.ReadLine();
            BankCode = CardNumber.Substring(0, 6);
            IBank bank = bankFactory.GetBank(BankCode);
            Console.WriteLine(bank.withdraw());
            Console.ReadKey();
        }
    }
}
