using Entities;

namespace Services
{
    public class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService taxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            this.taxService = taxService;
        }
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment;
            if(duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = taxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);   
        }
    }
}