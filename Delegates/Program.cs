using Entities;

namespace Delegates
{
    internal class Program
    {
        static void UpdatePrice(Product p) => p.Price += p.Price * 0.1;
        private static void Main(string[] args)
        {
            PredicateSample predSample = new PredicateSample();
            //ActionSample actSample = new ActionSample();


            Console.ReadKey();
        }
    }
}