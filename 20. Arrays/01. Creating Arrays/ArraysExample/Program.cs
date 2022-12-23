using System;

namespace ArraysExample
{
    class Program
    {
        static void Main()
        {
            //create an array
            int[] a = new int[5] { 10, 20, 30, 40, 50 };
            string[] b = new string[5] { "one", "two", "three", "four", "five" };

            //display the values of elements
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);
            Console.WriteLine();
            Console.WriteLine(b[0]);
            Console.WriteLine(b[1]);
            Console.WriteLine(b[2]);
            Console.WriteLine(b[3]);
            Console.WriteLine(b[4]);

            Console.ReadKey();
        }
    }
}
