using Entities;

namespace IComparableSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = "data2.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        string? line = sr.ReadLine();
                        if (line != null) list.Add(new Employee(line));
                    }
                    list.Sort();
                    foreach (Employee item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.ReadKey();
        }
    }
}