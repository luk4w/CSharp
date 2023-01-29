namespace FileDictionary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string path = "file.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string? line = sr.ReadLine();
                            if (!string.IsNullOrEmpty(line))
                            {
                                string[] data = line.Split(',');
                                string name = data[0];
                                int votes = int.Parse(data[1]);

                                if (dictionary.ContainsKey(name))
                                    dictionary[name] += votes;
                                else
                                    dictionary.Add(name, votes);
                            }
                        }
                    }

                    foreach (KeyValuePair<string, int> item in dictionary)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
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