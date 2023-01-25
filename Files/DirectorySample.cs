namespace Files
{
    public class DirectorySample
    {
        public DirectorySample()
        {

            string pathFolder = "docs";
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(pathFolder, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Folders:");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(pathFolder, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Files:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                // Create new folder
                // Directory.CreateDirectory(pathFolder+"/New Folder");

            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}