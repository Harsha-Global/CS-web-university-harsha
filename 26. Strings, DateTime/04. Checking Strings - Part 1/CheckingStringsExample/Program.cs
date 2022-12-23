using System;
using System.Collections.Generic;

namespace CheckingStringsExample
{
    class Program
    {
        static void Main()
        {
            string str = "Universe";
            string str2 = "Universe";

            bool eq = str.Equals(str2);
            bool eq2 = str == str2;

            Console.WriteLine("Equals: " + eq);  //Output: true
            Console.WriteLine("==: " + eq2);  //Output: true

            bool sw = str.StartsWith("U");
            Console.WriteLine("StartsWith: " + sw);  //Output: true
            bool sw2 = str.StartsWith("e");
            Console.WriteLine("StartsWith: " + sw2);  //Output: false

            bool ew = str.EndsWith("e");
            bool ew2 = str.EndsWith("U");
            Console.WriteLine("Ends with: " + ew);  //Output: true
            Console.WriteLine("Ends with: " + ew2);  //Output: false

            bool ct = str.Contains("e");
            bool ct2 = str.Contains("t");
            Console.WriteLine("Contains: " + ct); //Output: true
            Console.WriteLine("Contains: " + ct2); //Output: false

            Console.ReadKey();
        }
    }
}
