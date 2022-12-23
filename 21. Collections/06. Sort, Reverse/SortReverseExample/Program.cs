using System;
using System.Collections.Generic;

namespace SortReverseExample
{
    class Program
    {
        static void Main()
        {
            //create a list
            List<double> myNumbers = new List<double>() { 170, 150, 445, 120, 10, 4, 661 };

            //sort - asc
            myNumbers.Sort();

            //reverse
            myNumbers.Reverse();

            //after sorting
            foreach (double value in myNumbers)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
