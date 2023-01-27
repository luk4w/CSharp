namespace IComparableSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = "data1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string>? list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        string? line = sr.ReadLine();
                        if (line != null) list.Add(line);
                    }
                    list.Sort();
                    foreach (string item in list)
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