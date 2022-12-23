using System;
using System.Collections.Generic;

namespace AnonymousArraysExample
{
    class Program
    {
        static void Main()
        {
            //create anonymous array / implicitly typed array
            var persons = new[ ] {
                new { PersonName = "Scott", Email = "scott@gmail.com" },
                new { PersonName = "Smith", Email = "smith@gmail.com" },
                new { PersonName = "Allen", Email = "allen@gmail.com" },
                new { PersonName = "Jones", Email = "jones@gmail.com"  }
            };

            //foreach
            foreach (var item in persons)
            {
                Console.Write(item.PersonName);
                Console.Write(", ");
                Console.WriteLine(item.Email);
            }

            Console.ReadKey();
        }
    }
}
