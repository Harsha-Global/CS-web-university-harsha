using System;

namespace AsciiExample
{
    class Program
    {
        static void Main()
        {
            char ch = 'A';
            byte b = (byte)ch;
            Console.WriteLine(b); //65
            char ch2 = (char)b;
            Console.WriteLine(ch2); //A

            //generate byte[]
            byte[] bytes = new byte[128];
            for (byte i = 0; i < 128; i++)
            {
                bytes[i] = i;
            }
            string s = System.Text.Encoding.ASCII.GetString(bytes); //byte[] to string
            Console.OutputEncoding = System.Text.Encoding.ASCII;
            Console.WriteLine(s);


            string sentence = "The quick brown fox jumps over the lazy dog";
            byte[] bytes2 = System.Text.Encoding.ASCII.GetBytes(sentence); //string to byte[]
            string sentence2 = System.Text.Encoding.ASCII.GetString(bytes2); //byte[] to string
            Console.WriteLine(sentence2);
            Console.ReadKey();
        }
    }
}
