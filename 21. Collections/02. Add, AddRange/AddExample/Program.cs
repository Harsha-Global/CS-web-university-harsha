using System;
using System.Collections.Generic;

namespace AddExample
{
    class Program
    {
        static void Main()
        {
            //create reference variable for List class & create object of List class
            List<int> myList = new List<int>(10) { 10, 20, 30 };

            //add new element at the end of existing collection
            myList.Add(40);

            //another collection
            List<int> otherList = new List<int>() { 50, 60, 70 };

            //adding another collection to existing collection
            myList.AddRange(otherList);

            //read elements using foreach loop
            Console.WriteLine("Using foreach loop:");
            foreach (int item in myList)
            {
                Console.WriteLine(item); //Output: 10 20 30 40 50 60 70
            }

            Console.ReadKey();
        }
    }
}
