using System.Globalization;

namespace Entities
{
    public class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(",");
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"{Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object? obj)
        {
            if(obj is Employee)
            {
                Employee? other = obj as Employee;
                if(other != null)
                    return Salary.CompareTo(other.Salary);
                else
                    throw new ArgumentException("Null object");
            }
            else
                throw new ArgumentException("Incompatible object type");
        }
    }
}