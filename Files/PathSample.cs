namespace Files
{
    public class PathSample
    {
        public PathSample()
        {
            string path = "docs/file1.txt";

            Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
            Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}");
            Console.WriteLine($"GetFileName: {Path.GetFileName(path)}");
            Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"GetExtension: {Path.GetExtension(path)}");
            Console.WriteLine($"GetFullPath: {Path.GetFullPath(path)}");
            Console.WriteLine($"GetTempPath: {Path.GetTempPath()}");

        }
    }
}