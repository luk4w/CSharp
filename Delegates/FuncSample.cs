using Entities;

namespace Delegates
{
    public class FuncSample
    {
        // public static string NameUpper(Product p) => p.Name.ToUpper();
        public FuncSample()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Notebook", 2100));
            list.Add(new Product("TV", 1000));
            list.Add(new Product("Mouse", 180));
            list.Add(new Product("Keyboard", 300));
            list.Add(new Product("Monitor", 1700));

            // Func<Product, string> func = NameUpper;
            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> strList = list.Select(func).ToList();
            foreach (string str in strList)
            {
                Console.WriteLine(str);
            }
        }
    }
}