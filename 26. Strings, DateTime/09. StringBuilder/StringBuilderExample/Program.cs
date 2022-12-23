using System;
using System.Text;
//System.Text.StringBuilder

namespace StringBuilderExample
{
    class Program
    {
        static void Main()
        {
            //create an array of strings
            string[] words = new string[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };
            //Expected output: "The quick brown fox jumps over the lazy dog"
            string sentence = "";
            foreach (string word in words)
            {
                sentence = sentence + " " + word; //Problem: new object will be created for each iteration.
                //1st iteration: " The"
                //2nd iteration: " The quick"
                //...
            }
            //Console.WriteLine(sentence);

            //StringBuilder
            StringBuilder builder = new StringBuilder();
            foreach (string word in words)
            {
                builder.Append(word);
                builder.Append(" ");
                Console.WriteLine(builder.ToString() + ", " + builder.Length + ", " + builder.Capacity);
            }
            Console.WriteLine(builder.ToString());
            Console.ReadKey();
        }
    }
}
