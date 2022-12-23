using System;
using System.Collections.Generic;
using System.Linq;

namespace StringForLoopExample
{
    class Program
    {
        static void Main()
        {
            string name = "developer@example.com";
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            //for loop
            int vowelsCount = 0;
            for (int i = 0; i < name.Length; i++)
            {
                bool isMatch = false;
                for (int j = 0; j < vowels.Length; j++)
                    if (name[i] == vowels[j])
                        isMatch = true;

                if (isMatch)
                    vowelsCount++;

                //Console.WriteLine(name[i] + " " + isMatch);
            }
            Console.WriteLine(vowelsCount + " vowels found");
            //i = 0  name[i]  name[0]

            //Using methods of arrays / collections
            vowelsCount = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (Array.IndexOf(vowels, name[i]) >= 0)
                    vowelsCount++;
            }
            Console.WriteLine(vowelsCount + " vowels found");

            //Using LINQ
            Console.WriteLine(name.Count(ch => Array.IndexOf(vowels, ch) >= 0) + " vowels found");
            Console.ReadKey();
        }
    }
}
