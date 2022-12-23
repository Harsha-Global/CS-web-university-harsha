using System;
using System.IO;

namespace FileReadWriteExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"c:\practice\dog.txt";
            string content = "The dog is one of the common domestic animal.";

            //WriteAllText
            File.WriteAllText(filePath, content);
            Console.WriteLine("dog.txt created");

            //ReadAllText
            string s = File.ReadAllText(filePath);
            Console.WriteLine("\nFile read:");
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
