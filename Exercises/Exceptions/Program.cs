using Exceptions.Entities;
using Exceptions.Entities.Exceptions;

namespace Exceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(8021, "Bob Brown", 500, 300);
                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                acc.Withdraw(amount);
                Console.WriteLine($"New balance: {acc.Balance}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.ReadKey();
        }
    }
}