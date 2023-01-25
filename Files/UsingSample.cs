namespace Files;

public class UsingSample
{
    public UsingSample()
    {
        string path = "file1.txt";
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            using (StreamReader sr = new StreamReader(fs))
            {
                try
                {
                    while (!sr.EndOfStream)
                    {
                        string? line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
    }
}