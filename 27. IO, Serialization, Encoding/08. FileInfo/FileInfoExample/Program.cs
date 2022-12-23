using System;
using System.IO;

namespace FileInfoExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"c:\practice\japan.txt";
            string destPath = @"c:\practice\another.txt";
            string destPath2 = @"c:\practice\somethingelse.txt";

            FileInfo fileInfo = new FileInfo(filePath);

            //Create()
            fileInfo.Create().Close();
            Console.WriteLine("japan.txt created");

            //CopyTo()
            FileInfo fileInfo2 = fileInfo.CopyTo(destPath, true);
            Console.WriteLine(fileInfo2.Name + " created");

            //MoveTo()
            fileInfo2.MoveTo(destPath2);
            Console.WriteLine(fileInfo2.Name + " moved");

            //Delete()
            fileInfo2.Delete();
            Console.WriteLine(fileInfo2.Name + " deleted");
            Console.ReadKey();
        }
    }
}
