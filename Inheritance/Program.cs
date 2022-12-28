﻿using Inheritance.Entities;

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
            
            Console.ReadKey();
        }
    }
}