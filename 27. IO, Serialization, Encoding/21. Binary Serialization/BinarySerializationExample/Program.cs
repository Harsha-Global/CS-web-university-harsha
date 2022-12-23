using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializationExample
{
    [Serializable]
    public class Country
    {
        public short CountryID { get; set; }
        public string CountryName { get; set; }
        public long Population { get; set; }
        public string Region { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //Serialization
            Country country = new Country() { CountryID = 1, CountryName = "Russia", Population = 145934000, Region = "Eastern Europe" };

            //create FileStream
            string filePath = @"c:\practice\russia.txt";
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            //create BinaryFormatter
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, country);
            fileStream.Close();
            Console.WriteLine("Serialized");

            //Code for deserialization
            FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            Country country_from_file = (Country)binaryFormatter.Deserialize(fileStream2);
            Console.WriteLine("\nData after deserialization:");
            Console.WriteLine("Country ID: " + country_from_file.CountryID);
            Console.WriteLine("Country Name: " + country_from_file.CountryName);
            Console.WriteLine("Population: " + country_from_file.Population);
            Console.WriteLine("Region: " + country_from_file.Region);

            Console.ReadKey();
        }
    }
}
