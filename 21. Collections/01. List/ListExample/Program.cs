using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main()
        {
            //create reference variable for List class & create object of List class
            List<int> myList = new List<int>(10) { 10, 20, 30 };

            //read elements using foreach loop
            Console.WriteLine("Using foreach loop:");
            foreach (int item in myList)
            {
                Console.WriteLine(item); //Output: 10 20 30
            }

            //read elements using foreach loop
            Console.WriteLine("\nUsing for loop:");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]); //Output: 10 20 30
            }

            Console.ReadKey();
        }
    }
}
