using System;

namespace UnicodeExample
{
    class Program
    {
        static void Main()
        {
            string mytext = "ﺱ";
            Console.WriteLine(mytext);
            string mytext2 = "\u0543";
            Console.WriteLine(mytext2);

            string sentence = "The quick brown fox jumps over the lazy dog";
            byte[] bytes = System.Text.Encoding.Unicode.GetBytes(sentence); //string to byte[]
            string sentence2 = System.Text.Encoding.Unicode.GetString(bytes); //byte[] to string
            Console.WriteLine(sentence2);

            Console.ReadKey();
        }
    }
}
