using System.Globalization;
using Entities;

namespace FileLINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            string path = "data.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string? line = sr.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] fields = line.Split(',');
                            string name = fields[0];
                            double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                            products.Add(new Product(name, price));
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            double avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Average: {avg.ToString("F2", CultureInfo.InvariantCulture)}\n");

            IOrderedEnumerable<Product> listDesceding = products.Where(p => p.Price < avg).OrderByDescending(p => p.Price);

            Console.WriteLine($"Below average prices:");
            foreach (Product p in listDesceding)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }
}