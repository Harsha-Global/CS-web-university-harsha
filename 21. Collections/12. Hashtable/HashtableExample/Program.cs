using System;
using System.Collections;

namespace HashtableExample
{
    class Program
    {
        static void Main()
        {
            //create a hashtable
            Hashtable employees = new Hashtable()
            {
                { 102, "Smith" },
                { 105, "James" },
                { 103, "Allen" },
                { 101, "Scott" },
                { 104, "Jones" },
                { "hello", 10.934 }
            };

            //Add element
            employees.Add(106, "Anna");

            //Remove element
            employees.Remove(103);

            //foreach
            foreach (DictionaryEntry item in employees)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            //get value based on key
            if( employees[105] is string)
            {
                string value = Convert.ToString(employees[105]);
                Console.WriteLine(value);
            }
            else if (employees[105] is double)
            {
                double value = Convert.ToDouble(employees[105]);
                Console.WriteLine(value);
            }

            //search for specific key
            bool k = employees.ContainsKey(105);
            Console.WriteLine("\n105 exists: " + k);

            //search for specific value
            bool v = employees.ContainsValue("Scott");
            Console.WriteLine("\nScott exists: " + v);

            //Keys
            Console.WriteLine("\nKeys:");
            foreach (var item in employees.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("\nValues:");
            foreach (var item in employees.Values)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
