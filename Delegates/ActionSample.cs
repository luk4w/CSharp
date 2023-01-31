using Entities;

namespace Delegates
{
    public class ActionSample
    {
        public ActionSample()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Notebook", 2100));
            list.Add(new Product("TV", 1000));
            list.Add(new Product("Mouse", 180));
            list.Add(new Product("Keyboard", 300));
            list.Add(new Product("Monitor", 1700));

            //Action<Product> action =  UpdatePrice;
            Action<Product> action = (p) => { p.Price += p.Price * 0.1; };

            //list.ForEach(UpdatePrice);
            list.ForEach(action);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}