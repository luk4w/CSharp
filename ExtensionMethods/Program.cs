using Extensions;

namespace ExtensionMethods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // DateTime dt = new DateTime(2023, 01, 29, 21, 15, 0);
            // Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

            Console.ReadKey();
        }
    }
}