using Entities;

namespace Delegates
{
    public class PredicateSample
    {
        public PredicateSample()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Notebook", 2100));
            list.Add(new Product("TV", 1000));
            list.Add(new Product("Mouse", 180));
            list.Add(new Product("Keyboard", 300));
            list.Add(new Product("Monitor", 1700));

            list.RemoveAll( p => p.Price >= 500);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}