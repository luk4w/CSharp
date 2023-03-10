using Entities;

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

            // IEnumerable<Product> result1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            IEnumerable<Product>? result1 = from p in products
                                            where p.Category.Tier == 1 && p.Price < 900
                                            select p;
            Print("TIER 1 AND PRICE < 900:", result1);

            // IEnumerable<string> result2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            IEnumerable<string> result2 = from p in products
                                          where p.Category.Name == "Tools"
                                          select p.Name;
            Print("NAME OF PRODUCT FROM TOOLS:", result2);

            // Anonymous object
            // var r3 = products.Where(p => p.Name.ToUpper()[0] == 'C').Select(p => new { p.Name, Price = p.Price, CategoryName = p.Category.Name });
            var r3 = from p in products
                     where p.Name[0] == 'C'
                     select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:", r3);

            // Ordination
            // IEnumerable<Product> r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            IEnumerable<Product> r4 = from p in products
                                      where p.Category.Tier == 1
                                      orderby p.Name
                                      orderby p.Price
                                      select p;
            Print("TIER 1 AND ORDER BY PRICE THEN BY NAME", r4);

            // IEnumerable<Product> r5 = r4.Skip(2).Take(4);
            IEnumerable<Product> r5 = (from p in r4
                                       select p).Skip(2).Take(4);
            Print("TIER 1 AND ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            // Product? r6 = products.FirstOrDefault();
            Product? r6 = (from p in products select p).FirstOrDefault();
            Console.WriteLine($"FIRST OR DEFAULT: {r6}");

            // Product? r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Product? r7 = (from p in products
                           where p.Price > 3000
                           select p).FirstOrDefault();
            Console.WriteLine($"FIRST OR DEFAULT AND PRICE > 3000: {r7}");

            // Product? r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Product? r8 = (from p in products
                           where p.Id == 3
                           select p).SingleOrDefault();
            Console.WriteLine($"ID == 3 SINGLE OR DEFAULT: {r8}");

            // Product? r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            // Console.WriteLine($"ID == 30 SINGLE OR DEFAULT: {r9}");

            // double r10 = products.Max(p => p.Price);
            // Console.WriteLine($"MAX PRICE: {r10}");

            // double r11 = products.Min(p => p.Price);
            // Console.WriteLine($"MIN PRICE: {r11}");

            // double r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            // Console.WriteLine($"CATEGORY 1 SUM PRICES: {r12}");

            // double r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            // Console.WriteLine($"CATEGORY 1 AVERAGE PRICES: {r13}");

            // double r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            // Console.WriteLine($"CATEGORY 5 (NOT EXIST) AVERAGE PRICES: {r14}");

            // double r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            // Console.WriteLine($"CATEGORY 1 AGGREGATE SUM: {r15}\n");
            
            // IEnumerable<IGrouping<Category, Product>>? r16 = products.GroupBy(p => p.Category);
            IEnumerable<IGrouping<Category, Product>>? r16 = from p in products
                                                             group p by p.Category;
            Console.WriteLine();
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine($"Category {group.Key.Name}:");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}