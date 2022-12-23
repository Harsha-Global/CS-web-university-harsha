using System;
using System.Collections.Generic;

namespace ConvertingStringExample
{
    class Program
    {
        static void Main()
        {
            string str = "Developer";
            Console.WriteLine(str);  //Output: Developer
            string str_upr = str.ToUpper();
            Console.WriteLine("Upper: " + str_upr); //Output: DEVELOPER
            string str_lwr = str.ToLower();
            Console.WriteLine("Lower: " + str_lwr); //Output: developer

            string str_sub = str.Substring(4);
            Console.WriteLine("Substring at 4: " + str_sub);  //Output: loper
            string str_sub2 = str.Substring(4, 3);
            Console.WriteLine("Substring at 4,3: " + str_sub2);  //Output: lop

            string str_rpl = str.Replace("e", "a");
            Console.WriteLine("Replace: " + str_rpl); //Output: Davalopar

            string message = "how are you";
            string[] words = message.Split(' ');
            Console.WriteLine("\nSplit:");
            foreach(string word in words)
            {
                Console.WriteLine(word); //Output: how, are, you
            }

            string message_with_spaces = "  hello   ";
            string str_trm = message_with_spaces.Trim();
            Console.WriteLine("Trim: " + str_trm); //Output: hello

            char[] characters = str.ToCharArray();
            Console.WriteLine("\nCharacters:");
            foreach(char ch in characters)
            {
                Console.WriteLine(ch);  //Output: D,e,v,e,l,o,p,e,r
            }

            string[] my_words = new string[] { "how", "are", "you"}; //how-are-you
            string str_jn = string.Join("--", my_words);
            Console.WriteLine("Join: " + str_jn);

            char[] characters2 = new char[] { 'h', 'e', 'l', 'l', 'o' };
            string str2 = new string(characters2);
            Console.WriteLine("New string: " + str2);

            Console.ReadKey();
        }
    }
}
