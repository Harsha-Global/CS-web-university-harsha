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
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (string i in b)
            {
                Console.WriteLine(i);
            }

            //reverse
            Console.WriteLine();
            for (int i = b.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadKey();
        }
    }
}
