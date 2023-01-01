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
                Console.WriteLine(n1/n2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine($"Division by zero is not allowed!");
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Enter a number! {e.Message}");
            }

            Console.ReadKey();
        }
    }
}