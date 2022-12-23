using System;
using System.Collections.Generic;
using System.IO;

namespace FileLinesExample
{
    class Program
    {
        static void Main()
        {
            //collection
            List<string> asia = new List<string>() {  "Russia", "China", "India"};

            //file path
            string filePath = @"c:\practice\asia.txt";

            //WriteAllLines
            File.WriteAllLines(filePath, asia);
            Console.WriteLine("asia.txt created");

            //ReadAllLines
            string[] existingContent = File.ReadAllLines(filePath);
            foreach(string line in existingContent)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}
