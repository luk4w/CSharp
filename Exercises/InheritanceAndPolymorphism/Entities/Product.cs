using System.Globalization;

namespace InheritanceAndPolymorphism.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(){}

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        
        virtual public string PriceTag()
        {
            return string.Format($"{Name} $ {Price.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}