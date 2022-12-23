using System;
using ClassLibrary1;

namespace EventsExample
{
    //subscriber class
    class Program
    {
        static void Main()
        {
            //create obj of Publisher class
            Publisher publisher = new Publisher();

            //handle the event (or) subscribe to event
            publisher.myEvent += (a, b) => a + b;

            //invoke the event
            Console.WriteLine(publisher.RaiseEvent(10, 20));
            Console.WriteLine(publisher.RaiseEvent(5, 80));
            Console.WriteLine(publisher.RaiseEvent(14, 22));

            Console.ReadKey();
        }
    }
}
