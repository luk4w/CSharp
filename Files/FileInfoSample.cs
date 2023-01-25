using System;
using System.IO;

namespace Files
{
    public class FileInfoSample
    {
        public FileInfoSample()
        {
            string sourcePath = "file1.txt";
            string targetPath = "file2.txt";

            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}