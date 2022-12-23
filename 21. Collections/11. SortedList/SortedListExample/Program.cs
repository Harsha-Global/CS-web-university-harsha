using System;
using System.Collections.Generic;

namespace SortedListExample
{
    class Program
    {
        static void Main()
        {
            //create a sortedlist
            SortedList<int, string> employees = new SortedList<int, string>()
            {   
                { 102, "Smith" },
                { 105, "James" },
                { 103, "Allen" },
                { 101, "Scott" },
                { 104, "Jones" }
            };

            //Add element
            employees.Add(106, "Anna");

            //Remove element
            employees.Remove(103);

            //foreach
            foreach (KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            //get value based on key
            string eName = employees[105];
            Console.WriteLine("\nEmployee name at 105: " + eName);

            //search for specific key
            bool k = employees.ContainsKey(105);
            Console.WriteLine("\n105 exists: " + k);

            //search for specific value
            bool v = employees.ContainsValue("Scott");
            Console.WriteLine("\nScott exists: " + v);

            //index of specific key
            int ki = employees.IndexOfKey(101);
            Console.WriteLine("\nIndex of 101: " + ki);

            //index of specific value
            int vi = employees.IndexOfValue("Allen");
            Console.WriteLine("\nIndex of Allen: " + vi);

            //Keys
            Console.WriteLine("\nKeys:");
            foreach (int item in employees.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("\nValues:");
            foreach (string item in employees.Values)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
