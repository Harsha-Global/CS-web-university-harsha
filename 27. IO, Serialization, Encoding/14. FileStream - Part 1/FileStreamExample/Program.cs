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
            //FileStream fileStream = fileInfo.Open(FileMode.Create, FileAccess.Write);
            FileStream fileStream = fileInfo.OpenWrite();

        }
    }
}
