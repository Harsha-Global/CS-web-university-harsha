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
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
            
            Console.ReadKey();
        }
    }
}
