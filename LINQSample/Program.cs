﻿using Entities;

namespace LINQSample
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
                Console.WriteLine(obj);
            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            List<Product> products = new List<Product>()
            {
                new Product(1, "Computer", 1100.0, c2),
                new Product(2, "Hammer", 90.0, c1),
                new Product(3, "TV", 1700.0, c3),
                new Product(4, "Notebook", 1300.0, c2),
                new Product(5, "Saw", 80.0, c1),
                new Product(6, "Tablet", 700.0, c2),
                new Product(7, "Camera", 700.0, c3),
                new Product(8, "Printer", 350.0, c3),
                new Product(9, "MacBook", 1800.0, c2),
                new Product(10, "Sound Bar", 700.0, c3),
                new Product(11, "Level", 70.0, c1)
            };

            IEnumerable<Product> result1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            Print("TIER 1 AND PRICE < 900:", result1);

            IEnumerable<string> result2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAME OF PRODUCT FROM TOOLS:", result2);

            // Anonymous object
            var r3 = products.Where(p => p.Name.ToUpper()[0] == 'C').Select(p => new { p.Name, Price = p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:", r3);
            
            // Ordination
            IEnumerable<Product> r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 AND ORDER BY PRICE THEN BY NAME", r4);

            IEnumerable<Product> r5 = r4.Skip(2).Take(4);
            Print("TIER 1 AND ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            Product? r6 = products.FirstOrDefault();
            Console.WriteLine($"FIRST OR DEFAULT: {r6}");

            Product? r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine($"FIRST OR DEFAULT AND PRICE > 3000: {r7}");

            Product? r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine($"ID == 3 SINGLE OR DEFAULT: {r8}");

            Product? r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine($"ID == 30 SINGLE OR DEFAULT: {r9}");

            Console.ReadKey();
        }
    }
}