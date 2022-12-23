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

            string name = "developer";
            int ind1 = name.IndexOf("e"); //1
            int ind2 = name.IndexOf("vel"); //2
            int ind3 = name.IndexOf("gel"); //-1
            int ind4 = name.IndexOf("e", 2); //prev start index + 1 //3
            int ind5 = name.IndexOf("e", 4); //prev start index + 1 //7
            Console.WriteLine("Index Of e: " + ind1);
            Console.WriteLine("Index Of vel: " + ind2);
            Console.WriteLine("Index Of gel: " + ind3);
            Console.WriteLine("Index Of e,2: " + ind4);
            Console.WriteLine("Index Of ind5: " + ind5);

            int ind6 = name.LastIndexOf("e"); //7
            int ind7 = name.LastIndexOf("vel"); //2
            int ind8 = name.LastIndexOf("gel"); //-1
            int ind9 = name.LastIndexOf("e", 2); //prev start index + 1 //1
            int ind10 = name.LastIndexOf("e", 4); //prev start index + 1 //3
            Console.WriteLine("LastIndexOf Of e: " + ind6);
            Console.WriteLine("LastIndexOf Of vel: " + ind7);
            Console.WriteLine("LastIndexOf Of gel: " + ind8);
            Console.WriteLine("LastIndexOf Of e,2: " + ind9);
            Console.WriteLine("LastIndexOf Of ind5: " + ind10);

            string user_input = null;
            string user_input2 = "";
            string user_input3 = " ";
            bool noe1 = string.IsNullOrEmpty(user_input);
            bool noe2 = string.IsNullOrEmpty(user_input2);
            bool noe3 = string.IsNullOrEmpty(user_input3);

            Console.WriteLine("IsNullOrEmpty - null: " + noe1);
            Console.WriteLine("IsNullOrEmpty - \"\": " + noe2);
            Console.WriteLine("IsNullOrEmpty - \" \": " + noe3);
            if (string.IsNullOrEmpty(user_input))
            {
                //don't store the value into property
            }

            bool now1 = string.IsNullOrWhiteSpace(user_input);
            bool now2 = string.IsNullOrWhiteSpace(user_input2);
            bool now3 = string.IsNullOrWhiteSpace(user_input3);

            Console.WriteLine("IsNullOrWhiteSpace - null: " + now1);
            Console.WriteLine("IsNullOrWhiteSpace - \"\": " + now2);
            Console.WriteLine("IsNullOrWhiteSpace - \" \": " + now3);

            Console.ReadKey();
        }
    }
}
