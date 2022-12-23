using System;
using System.Collections.Generic;

namespace ToArrayForEachExample
{
    class Program
    {
        static void Main()
        {
            //create list
            List<string> myFriends = new List<string>() { "Scott", "Allen", "James", "Jones" };

            //convert to array
            string[] myFriendsArray = myFriends.ToArray();

            //display array
            foreach (string item in myFriendsArray)
            {
                Console.WriteLine(item);
            }

            //ForEach method
            Console.WriteLine("\nForEach method:");
            myFriends.ForEach(
                friend => { Console.WriteLine(friend); }
                );
            Console.ReadKey();
        }
    }
}
