using System;

namespace SortExample
{
    class Program
    {
        static void Main()
        {
            //create array
            int[] a = new int[] { 67, 12, 99, 4, 500, 125 };

            //sort ascending order
            Array.Sort(a);

            //display array after sort
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
