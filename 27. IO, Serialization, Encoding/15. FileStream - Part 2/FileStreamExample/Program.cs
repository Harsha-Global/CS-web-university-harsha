using System;
using System.IO;

namespace FileStreamExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"c:\practice\dog.txt";
            FileInfo fileInfo = new FileInfo(filePath);

            //FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //FileStream fileStream = File.Create(filePath);
            //FileStream fileStream = File.Open(filePath, FileMode.Create, FileAccess.Write);
            //FileStream fileStream = File.OpenWrite(filePath);
            //FileStream fileStream = fileInfo.Create();
            FileStream fileStream = fileInfo.Open(FileMode.Create, FileAccess.Write);
            //FileStream fileStream = fileInfo.OpenWrite();

            //create content
            string content = "Dog is one of the domestic animal.";
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(content);

            //Write
            fileStream.Write(bytes, 0, bytes.Length);
            //some work here
            string content2 = "other text here";
            byte[] bytes2 = System.Text.Encoding.ASCII.GetBytes(content2);
            fileStream.Write(bytes2, 0, bytes2.Length);

            fileStream.Close();
            Console.WriteLine("dog.txt created");

            Console.ReadKey();
        }
    }
}
