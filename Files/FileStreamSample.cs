namespace Files
{
    public class FileStreamSample
    {
        public FileStreamSample()
        {
            string path = "file1.txt";
            FileStream? fs = null;
            StreamReader? sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string? line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}