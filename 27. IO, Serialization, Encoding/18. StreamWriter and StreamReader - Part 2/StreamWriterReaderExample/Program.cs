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

            //3 ways to create object of StreamReader:
            //StreamReader streamReader = new StreamReader(filePath);
            //StreamReader streamReader = fileInfo.OpenText()
            FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fileStream2))
            {
                Console.WriteLine("\nFile read. File content is:");

                //To read full file
                //string content_from_file = streamReader.ReadToEnd();
                //Console.WriteLine(content_from_file);

                //To read part-by-part (10 characters)
                char[] buffer = new char[10];
                int char_count;
                do
                {
                    char_count = streamReader.Read(buffer, 0, 10);
                    string s1 = new string(buffer);
                    Console.WriteLine(s1);
                } while (char_count > 0);
            }

            Console.ReadKey();
        }
    }
}
