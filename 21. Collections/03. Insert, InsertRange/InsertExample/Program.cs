using System;
using System.Collections.Generic;

namespace InsertExample
{
    class Program
    {
        static void Main()
        {
            //create reference variable for List class & create object of List class
            List<int> myList = new List<int>(10) { 10, 20, 30 };

            //insert element at position 1
            myList.Insert(1, 100);

            //insert elements at position 2
            List<int> otherList = new List<int>() { 200, 300, 400 };
            myList.InsertRange(2, otherList);

            //read elements using foreach loop
            Console.WriteLine("Using foreach loop:");
            foreach (int item in myList)
            {
                Console.WriteLine(item); //Output: 10, 100, 20, 30
            }

            Console.ReadKey();
        }
    }
}
