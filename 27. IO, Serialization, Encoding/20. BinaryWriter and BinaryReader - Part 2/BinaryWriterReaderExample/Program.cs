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

            //BinaryReader
            FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (BinaryReader binaryReader = new BinaryReader(fileStream2))
            {
                int countryId_from_file = binaryReader.ReadInt16();
                string countryName_from_file = binaryReader.ReadString();
                long population_from_file = binaryReader.ReadInt64();
                string region_from_file = binaryReader.ReadString();

                Console.WriteLine("Country ID: " + countryId_from_file);
                Console.WriteLine("Country Name: " + countryName_from_file);
                Console.WriteLine("Population: " + population_from_file);
                Console.WriteLine("Region: " + region_from_file);
            }
               
            Console.ReadKey();
        }
    }
}
