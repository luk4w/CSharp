using System.Globalization;

namespace Exceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                double result = (double)n1 / n2;
                Console.WriteLine(result.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine($"Division by zero is not allowed!");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Enter an integer! {e.Message}");
            }

            Console.ReadKey();
        }
    }
}