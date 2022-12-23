using System;

namespace NullPropagationOperatorExample
{
    class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main()
        {
            //p1 is null
            Person p1 = null;

            //print age
            Console.WriteLine( p1?.Age );

            Console.ReadKey();
        }
    }
}
