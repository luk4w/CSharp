using Inheritance.Entities;

namespace Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Account acc1 = new Account(01, "Gauss", 500.0);

            // Upcasting
            Account acc2 = new SavingsAccount(02, "Leon", 500.0, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine($"Account 1: {acc1.Balance}");
            Console.WriteLine($"Account 2: {acc2.Balance}");
   
            Console.ReadKey();
        }
    }
}