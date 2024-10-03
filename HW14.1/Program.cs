namespace HW14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(100, "Misha");
            Account account2 = new Account(50, "Alex");
            account1.Withdrawal(20);
            Console.WriteLine($"The balance of {account1.GetName()} account is now: {account1.Balance()}");
            account2.Deposit(200);
            Console.WriteLine($"The balance of {account2.GetName()} account is now: {account2.Balance()}");
        }
    }
}
