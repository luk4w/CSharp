using Entities;

namespace HashSetSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.WriteLine("Enter file path: ");
            string? input = Console.ReadLine();
            string path;
            if (!string.IsNullOrEmpty(input)) path = input;
            else throw new ArgumentNullException("Null or empty path!");

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string? line = sr.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] lines = line.Split(' ');
                            string name = lines[0];
                            DateTime instant = DateTime.Parse(lines[1]);
                            set.Add(new LogRecord(name, instant));
                        }
                    }
                    Console.WriteLine($"Total users: {set.Count}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}