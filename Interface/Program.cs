using System.Globalization;
using Entities;
using Services;

namespace Interface
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.Write("Car model: ");
            string? model = Console.ReadLine();
            if (string.IsNullOrEmpty(model)) throw new Exception("Null or empty model!");

            Console.Write("Pickup: (dd/MM/yyyy hh:mm): ");
            string? startDate = Console.ReadLine();
            if (string.IsNullOrEmpty(startDate)) throw new Exception("Null or empty date!");
            DateTime start = DateTime.ParseExact(startDate, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return: (dd/MM/yyyy hh:mm): ");
            string? finishDate = Console.ReadLine();
            if (string.IsNullOrEmpty(finishDate)) throw new Exception("Null or empty finish date!");
            DateTime finish = DateTime.ParseExact(finishDate, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Enter price per hour: ");
            string? pricePerHour = Console.ReadLine();
            if (string.IsNullOrEmpty(pricePerHour)) throw new Exception("Null or empty price per hour!");
            double hour = double.Parse(pricePerHour, CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            string? pricePerDay = Console.ReadLine();
            if (string.IsNullOrEmpty(pricePerDay)) throw new Exception("Null or empty price per day!");
            double day = double.Parse(pricePerDay, CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);

            Console.ReadKey();
        }
    }
}