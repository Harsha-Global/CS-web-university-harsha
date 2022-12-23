using System;
using System.Collections.Generic;

namespace HashSetExample3
{
    class Program
    {
        static void Main()
        {
            //create two HashSet's
            HashSet<string> employees2021 = new HashSet<string>() { "Amar", "Akhil", "Samareen" };
            HashSet<string> employees2022 = new HashSet<string>() { "John", "Scott", "Amar", "Akhil", "Smith", "David" };

            //IntersectWith
            employees2021.IntersectWith(employees2022);
            foreach (string item in employees2021)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
