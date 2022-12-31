using System.Globalization;
using AbstractMethod.Entities;

namespace AbstractMethod
{
    internal class Program
    {
        public static string RequestName()
        {
            Console.Write("Name: ");
            return Console.ReadLine();
        }

        public static double RequestAnnualIncome()
        {
            Console.Write("Annual income: ");
            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        private static void Main(string[] args)
        {
            List<Payer> payers = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char choice = char.Parse(Console.ReadLine());
                string name;
                double income;
                switch(choice)
                {
                    case 'i':
                        name = RequestName();
                        income = RequestAnnualIncome();
                        Console.Write("Health expenditures: ");
                        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        payers.Add(new Individual(name, income, healthExpenditures));
                        break;
                    case 'c':
                        name = RequestName();
                        income = RequestAnnualIncome();
                        Console.Write("Number of employees: ");
                        int numberOfEmployees = int.Parse(Console.ReadLine());
                        payers.Add(new Company(name, income, numberOfEmployees));
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        i--;
                        break;
                }              
            }
            Console.WriteLine("\nTAXES PAID:");
            double sum = 0.0;
            foreach (Payer p in payers)
            {
                double tax = p.Tax();
                Console.WriteLine($"{p.Name}: $ {p.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += tax;
            }
            Console.WriteLine($"\nTOTAL TAXES: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}