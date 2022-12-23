using System;

namespace BinarySearchExample
{
    class Program
    {
        static void Main()
        {
            //create array
            double[] a = new double[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            //search for 30 in the array (first half)
            int n = Array.BinarySearch(a, 30);
            Console.WriteLine("30 is found at " + n);

            //search for 100 in the array (second half)
            int n2 = Array.BinarySearch(a, 80);
            Console.WriteLine("100 is found at " + n2);

            Console.ReadKey();
        }
    }
}
