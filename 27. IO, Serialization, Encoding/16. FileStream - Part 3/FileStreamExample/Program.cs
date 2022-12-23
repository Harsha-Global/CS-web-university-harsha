using System;
using System.IO;
using System.Text;

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
            byte[] bytes2 = Encoding.ASCII.GetBytes(content2);
            fileStream.Write(bytes2, 0, bytes2.Length);

            fileStream.Close();
            Console.WriteLine("dog.txt created");

            //File reading
            //FileStream fileStream2 = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            //FileStream fileStream2 = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            //FileStream fileStream2 = File.OpenRead(filePath);
            //FileStream fileStream2 = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.Read);
            FileStream fileStream2 = fileInfo.OpenRead();

            //create empty byte[]
            byte[] bytes3 = new byte[fileStream2.Length];

            //Read
            fileStream2.Read(bytes3, 0, (int)fileStream2.Length);

            //convert byte[] to string
            string content3 = Encoding.ASCII.GetString(bytes3);
            Console.WriteLine("\nFile read. File content is:");
            Console.WriteLine(content3);
            fileStream2.Close();

            Console.ReadKey();
        }
    }
}
