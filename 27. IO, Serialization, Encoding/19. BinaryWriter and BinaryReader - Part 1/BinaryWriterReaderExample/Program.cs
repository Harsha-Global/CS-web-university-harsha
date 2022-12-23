using System;
using System.IO;

namespace BinaryWriterReaderExample
{
    class Program
    {
        static void Main()
        {
            short countryId = 1;
            string countryName = "France";
            long population = 65273511;
            string region = "Western Europe";
            string filePath = @"c:\practice\france.txt";
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
            {
                binaryWriter.Write(countryId); //0001
                binaryWriter.Write(countryName); //100 0100...
                binaryWriter.Write(population);
                binaryWriter.Write(region);
                //binaryWriter.Close(); //optional (in case of 'using' construct above)
            }
            Console.WriteLine("france.txt created");

            Console.ReadKey();
        }
    }
}
