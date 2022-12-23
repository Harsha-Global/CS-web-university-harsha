using System;

namespace namespace1
{
    class Person
    {
        public int? NoOfChildren;
    }
    class Program
    {
        static void Main()
        {
            //create object
            Person p1 = new Person() { NoOfChildren = 2 };
            Person p2 = new Person() { NoOfChildren = 3 };
            Person p3 = null;

            //Console.WriteLine(p1.NoOfChildren);
            Console.WriteLine(p2.NoOfChildren ?? 0);
            Console.ReadKey();
        }
    }
}
