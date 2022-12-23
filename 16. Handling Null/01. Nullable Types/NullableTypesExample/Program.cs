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
            Person p2 = new Person() { NoOfChildren = 5 };
            Person p3 = null;

            Console.WriteLine(p1.NoOfChildren);
            if (p2.NoOfChildren.HasValue)
            {
                int x = p2.NoOfChildren.Value;
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
