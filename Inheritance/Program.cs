using Inheritance.Entities;

namespace Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Account account = new Account(number: 01, holder: "Renata", balance: 100);
            BusinessAccount bAcc = new BusinessAccount(number: 02, holder: "Fahrenheit", balance: 0, loanLimit: 500);

            // Upcasting
            Account acc1 = bAcc;
            Account acc2 = new BusinessAccount(03, "Gauss", 0, 200);
            Account acc3 = new SavingsAccount(04, "Joana", 0, 0.01);

            // Downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);
            //((BusinessAccount)acc2).Loan(100);

            if(acc3 is BusinessAccount) // Example: always false, because acc3 is SavingsAccount
            {
                // BusinessAccount acc5 = acc3 as BusinessAccount;
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(100);
                Console.WriteLine("Loan!");
            }
            else if (acc3 is SavingsAccount)
            {
                // SavingsAccount acc5 = acc3 as SavingsAccount;
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update Balance!");
            }
            
            Console.ReadKey();
        }
    }
}