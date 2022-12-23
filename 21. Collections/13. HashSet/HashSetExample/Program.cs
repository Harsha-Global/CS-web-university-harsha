using System;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {
        static void Main()
        {
            //create an object of HashSet
            HashSet<string> messages = new HashSet<string>()
            {
                "Good Morning", "How Are You", "Have a good day"
            };

            //Add
            messages.Add("Good Luck");

            //Remove
            messages.Remove("Have a good day");

            //Remove
            messages.RemoveWhere(m => m.EndsWith("You"));

            //Search
            bool b = messages.Contains("Good Morning");
            Console.WriteLine("Contains: " + b);

            //Count
            Console.WriteLine("Count: " + messages.Count);

            //foreach
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }


            Console.ReadKey();
        }
    }
}
