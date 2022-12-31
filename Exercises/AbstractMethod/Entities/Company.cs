namespace AbstractMethod.Entities
{
    public class Company : Payer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if(NumberOfEmployees > 10)
            {
                return 0.14 * AnnualIncome;
            }
            else
            {
                return 0.16 * AnnualIncome;
            }
        }
    }
}