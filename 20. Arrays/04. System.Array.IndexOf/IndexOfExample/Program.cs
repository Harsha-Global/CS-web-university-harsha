using System;

namespace IndexOfExample
{
    class Program
    {
        static void Main()
        {
            //create array
            double[] a = new double[6] { 10, 20, 30, 40, 50, 30 };

            //search for 30 in the array
            int n = Array.IndexOf(a, 30);
            Console.WriteLine("30 is found at " + n);

            //search for 30 in the array (second occurrence)
            int n2 = Array.IndexOf(a, 30, 3);
            Console.WriteLine("30 second occurrence is found at " + n2);

            //search for 100 in the array (not exists)
            int n3 = Array.IndexOf(a, 100);
            Console.WriteLine("100 is found at " + n3);

            Console.ReadKey();
        }
    }
}

