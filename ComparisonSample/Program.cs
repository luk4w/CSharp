using Entities;

namespace ComparisonSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Notebook", 2400.00));
            list.Add(new Product("Microwave", 500.00));
            list.Add(new Product("TV", 900.00));


            // Delegate method
            // Comparison<Product> comp = CompareProducts;
            // list.Sort(comp);

            // Lambda
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            list.Sort(comp);

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }

            Console.ReadKey();
        }

        // static int CompareProducts(Product p1, Product p2)
        // {
        //     return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        // }
    }
}