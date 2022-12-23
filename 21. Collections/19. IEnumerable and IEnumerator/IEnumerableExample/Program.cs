using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableExample
{
    class Program
    {
        static void Main()
        {
            //create a collection
            IEnumerable<string> messages;
            messages = new List<string>() { "How are you", "Have a great day", "Thanks for meeting" };

            //foreach
            Console.WriteLine("IEnumerable:");
            foreach (string item in messages)
            {
                Console.WriteLine(item);
            }

            //IEnumerator
            Console.WriteLine("\nIEnumerator:");
            IEnumerator<string> enumerator = messages.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current); //How are you
            }

            Console.ReadKey();
        }
    }
}
