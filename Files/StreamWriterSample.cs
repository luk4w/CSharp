using System.IO;
namespace Files
{
    public class StreamWriterSample
    {
        public StreamWriterSample()
        {
            string path = "file1.txt";
            string targetPath = "file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(path);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            
        }
    }
}