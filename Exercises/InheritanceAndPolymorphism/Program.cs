using System.Globalization;
using InheritanceAndPolymorphism.Entities;

namespace InheritanceAndPolymorphism
{
    internal class Program
    {
        private static Product CreateNewProduct()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            return new Product(name, price);
        }
        
        private static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char choice = char.Parse(Console.ReadLine());
                Product p;
                switch(choice)
                {   
                    case 'c':
                        products.Add(CreateNewProduct());
                        break;
                    case 'u':
                        p = CreateNewProduct();
                        Console.Write("Manufacture data (DD/MM/YYYY): ");
                        DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
                        UsedProduct uProduct = new UsedProduct(p, date);
                        products.Add(uProduct);
                        break;
                    case 'i':
                        p = CreateNewProduct();
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine());
                        ImportedProduct iProduct = new ImportedProduct(p, fee);
                        products.Add(iProduct);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        i--;
                        break;
                }
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
            
            Console.ReadKey();
        }
    }
}