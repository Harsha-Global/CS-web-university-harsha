using System;

namespace StringObjectsExample
{
    class Program
    {
        static void Main()
        {
            string x = "HELLO WORLD";
            string y = "HELLO WORLD";
            string z = x; //copies address from 'x' to 'z'
            x = "hello"; //creates a new string object
            Console.WriteLine(x); //hello
            Console.WriteLine(y); //HELLO WORLD
            Console.WriteLine(z); //HELLO WORLD
            Console.ReadKey();
        }
    }
}
