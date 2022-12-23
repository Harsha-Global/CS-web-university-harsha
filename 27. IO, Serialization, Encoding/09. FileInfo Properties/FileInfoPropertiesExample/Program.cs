using System;
using System.IO;

namespace FileInfoPropertiesExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"c:\practicee\japan.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            Console.WriteLine("Exists: " + fileInfo.Exists);
            if (fileInfo.Exists)
            {
                Console.WriteLine("FullName: " + fileInfo.FullName);
                //string s = fileInfo.FullName;
                Console.WriteLine("Name: " + fileInfo.Name);
                Console.WriteLine("DirectoryName: " + fileInfo.DirectoryName);
                Console.WriteLine("Extension: " + fileInfo.Extension);
                Console.WriteLine("Length: " + fileInfo.Length + " bytes");
                Console.WriteLine("LastWriteTime: " + fileInfo.LastWriteTime);
                Console.WriteLine("LastAccessTime: " + fileInfo.LastAccessTime);
                Console.WriteLine("CreationTime: " + fileInfo.CreationTime);
            }
            else
            {
                Console.WriteLine("File not found");
            }
            Console.ReadKey();
        }
    }
}
