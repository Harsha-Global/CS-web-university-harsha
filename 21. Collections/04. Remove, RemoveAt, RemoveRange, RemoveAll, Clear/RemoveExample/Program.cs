using System;
using System.Collections.Generic;

namespace RemoveExample
{
    class Program
    {
        static void Main()
        {
            //collection
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50 };

            //remove 30
            //myList.Remove(30);

            //remove at index 2
            //int ind = 5;
            //if (ind < myList.Count)
            //{
            //    myList.RemoveAt(ind);
            //    Console.WriteLine("Removed");
            //}

            //remove range starts from index 1; count is: 2 elements
            //myList.RemoveRange(1, 2);

            //remove all numbers > 30
            //myList.RemoveAll(n => n >= 30);

            //clear all
            myList.Clear();
            myList.Add(100);
            myList.Add(200);

            //foreach loop to print collection
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
