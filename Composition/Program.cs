﻿using System.Globalization;
using Composition.Entities;
using Composition.Entities.Enums;

namespace Composition
{
    internal class Program
    {
        private static void Main(string[] args)
        {   
            Console.WriteLine("Enter department's name:");
            string deptName = Console.ReadLine();
            
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Instantiate
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
               
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(hourContract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Split('/')[0]);
            int year = int.Parse(monthAndYear.Split('/')[1]);

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month)}");
            
            Console.ReadKey();
        }
    }
}