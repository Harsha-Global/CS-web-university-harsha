using System;
using System.IO;

namespace StreamWriterReaderExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"c:\practice\europe.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            //FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            //4 ways to create new object of StreamWriter
            //StreamWriter streamWriter = new StreamWriter(filePath);
            //StreamWriter streamWriter = new StreamWriter(fileStream);
            //StreamWriter streamWriter = fileInfo.AppendText();
            using (StreamWriter streamWriter = fileInfo.CreateText())
            {
                streamWriter.WriteLine("Russia has population about 145,934,000");
                //some code here
                streamWriter.WriteLine("Germany has population about 83,783,000");
                //some code here
                streamWriter.WriteLine("United Kingdom has population about 67,886,000");
                //streamWriter.Close(); //optional
            }

            Console.WriteLine("europe.txt created");
            Console.ReadKey();
        }
    }
}
