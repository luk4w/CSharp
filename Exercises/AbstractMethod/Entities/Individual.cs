namespace AbstractMethod.Entities
{
    public class Individual : Payer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(AnnualIncome < 20000)
            {
                return (0.15 * AnnualIncome - 0.5 * HealthExpenditures);
            }
            else
            {
                return (0.25 * AnnualIncome - 0.5 * HealthExpenditures);
            }
        }
    }
}