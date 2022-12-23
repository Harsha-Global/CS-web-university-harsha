using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerializerExample
{
    [Serializable]
    public class Continent
    {
        public string ContinentName { get; set; }
        public List<Country> Countries { get; set; }
    }

    [Serializable]
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //create data
            List<Continent> continents = new List<Continent>();
            continents.Add(new Continent()
            {
                ContinentName = "Africa",
                Countries =
                new List<Country>()
                {
                    new Country() { CountryID = 1, CountryName = "Sudan"},
                    new Country() { CountryID = 2, CountryName = "Libya"},
                    new Country() { CountryID = 3, CountryName = "South Africa"}
                }
            });

            continents.Add(new Continent()
            {
                ContinentName = "Asia",
                Countries =
                new List<Country>()
                {
                    new Country() { CountryID = 4, CountryName = "Russia"},
                    new Country() { CountryID = 5, CountryName = "China"},
                    new Country() { CountryID = 6, CountryName = "India"}
                }
            });

            continents.Add(new Continent()
            {
                ContinentName = "Europe",
                Countries =
                new List<Country>()
                {
                    new Country() { CountryID = 7, CountryName = "Russia"},
                    new Country() { CountryID = 8, CountryName = "Ukraine"},
                    new Country() { CountryID = 9, CountryName = "France"}
                }
            });

            continents.Add(new Continent()
            {
                ContinentName = "North America",
                Countries =
                new List<Country>()
                {
                    new Country() { CountryID = 10, CountryName = "Canada"},
                    new Country() { CountryID = 11, CountryName = "United States"},
                    new Country() { CountryID = 12, CountryName = "Mexico"}
                }
            });

            continents.Add(new Continent()
            {
                ContinentName = "South America",
                Countries =
                new List<Country>()
                {
                    new Country() { CountryID = 13, CountryName = "Brazil"},
                    new Country() { CountryID = 14, CountryName = "Argentina"},
                    new Country() { CountryID = 15, CountryName = "Peru"}
                }
            });
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Continent>));
            string filePath = @"c:\practice\continents.xml";

            //Serialize
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fileStream, continents);
            fileStream.Close();
            Console.WriteLine("continents.xml created");

            //Deserialize
            FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            List<Continent> continents_from_file = xmlSerializer.Deserialize(fileStream2) as List<Continent>;
            Console.WriteLine("\ncontinents.xml deserialized:");
            foreach (Continent cont in continents_from_file)
            {
                Console.WriteLine(cont.ContinentName);
                foreach(Country country in cont.Countries)
                {
                    Console.Write(country.CountryName + ", ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}


//Continent - with countries