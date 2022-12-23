using System;

namespace ClearExample
{
    class Program
    {
        static void Main()
        {
            //create array
            int[] a = new int[] { 10, 20, 30, 40, 50, 60 };

            //clear elements of array
            Array.Clear(a, 2, 3);

            //display array
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
