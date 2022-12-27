using Enumerations.Entities;
using Enumerations.Entities.Enums;

namespace Enumerations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,

            };

            Console.WriteLine(order);

            Console.ReadLine();
        }
    }
}