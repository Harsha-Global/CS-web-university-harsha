using System;
using ClassLibrary1;

namespace EventsExample
{
    public class Subscriber
    {
        //target method (event handler)
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
