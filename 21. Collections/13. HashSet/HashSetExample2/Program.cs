using System;
using System.Collections.Generic;

namespace HashSetExample2
{
    class Program
    {
        static void Main()
        {
            //create two HashSet's
            HashSet<string> employees2021 = new HashSet<string>() { "Amar", "Akhil", "Samareen" };
            HashSet<string> newEmployees2022 = new HashSet<string>() { "John", "Scott", "Smith", "David" };

            //Union
            employees2021.UnionWith(newEmployees2022);
            foreach (string item in employees2021)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
