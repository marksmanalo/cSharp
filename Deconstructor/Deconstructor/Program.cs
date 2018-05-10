using System;

namespace Deconstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            PathInfo pathInfo = new PathInfo(@"\\test\unc\path\to\something.ext");
            {
                // Example 1: Deconstructing declaration and assignment.
                (string directoryName, string fileName, string extension) = pathInfo;
                Console.WriteLine("Example 1:");
                Console.WriteLine(directoryName);
                Console.WriteLine(fileName);
                Console.WriteLine(extension);
            }
            {
                string directoryName, fileName, extension = null;
                // Example 2: Deconstructing assignment.
                (directoryName, fileName, extension) = pathInfo;
                Console.WriteLine("Example 2:");
                Console.WriteLine(directoryName);
                Console.WriteLine(fileName);
                Console.WriteLine(extension);
            }
            {
                // Example 3: Deconstructing declaration and assignment with var.
                var (directoryName, fileName, extension) = pathInfo;
                Console.WriteLine("Example 3:");
                Console.WriteLine(directoryName);
                Console.WriteLine(fileName);
                Console.WriteLine(extension);
            }

            Console.ReadLine();
        }
    }

    public class PathInfo
    {
        public string DirectoryName { get; }
        public string FileName { get; }
        public string Extension { get; }
        public string Path
        {
            get
            {
                return System.IO.Path.Combine(
                    DirectoryName, FileName, Extension);
            }
        }
        public PathInfo(string path)
        {
            DirectoryName = System.IO.Path.GetDirectoryName(path);
            FileName = System.IO.Path.GetFileNameWithoutExtension(path);
            Extension = System.IO.Path.GetExtension(path);
        }
        public void Deconstruct(
            out string directoryName, out string fileName, out string extension)
        {
            directoryName = DirectoryName;
            fileName = FileName;
            extension = Extension;
        }
    }
}
