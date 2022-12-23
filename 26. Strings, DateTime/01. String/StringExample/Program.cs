using System;

namespace StringExample
{
    class Program
    {
        static void Main()
        {
            string x = "Hello World"; //creates a string object
            int n = x.Length;  // count of characters
            char c = x[0]; //character at specific index
            Console.WriteLine(x);
            Console.WriteLine(n);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
