using System;

namespace IndexFromEndOperatorExample
{
    class Program
    {
        static void Main()
        {
            //create an array
            int[] a = new int[] { 10, 20, 30, 40, 50, 60 };

            //index-from-end operator
            int result = a[^0];
            Console.WriteLine(result); //Output: 60

            //range operator
            int[] result2 = a[2..5]; //Output: [20, 30, 40]
            foreach(int item in result2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
