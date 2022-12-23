using System;

namespace InsertExample
{
    class Program
    {
        static void Main()
        {
            string name = "Developer";
            //Devesadloper
            string name_updated = name.Insert(4, "sad");
            Console.WriteLine(name_updated);  //Output: Devesadloper

            string name_updated2 = name.Remove(2, 4);
            Console.WriteLine(name_updated2);  //Output: Deper
            Console.ReadKey();
        }
    }
}
