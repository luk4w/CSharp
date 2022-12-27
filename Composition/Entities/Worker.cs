using Composition.Entities.Enums;

namespace Composition.Entities
{
    public class Worker
    {
        public string? Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department? Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(){}

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        double Income(int year, int month)
        {
            double total = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    total += contract.TotalValue();
                }
            }
            return total;
        }
    }
}