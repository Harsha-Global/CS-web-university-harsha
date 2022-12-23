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
            publisher.myEvent += (a) =>
            {
                return a >= 0;
            };

            //invoke the event
            Console.WriteLine(publisher.RaiseEvent(10));
            Console.WriteLine(publisher.RaiseEvent(-5));
            Console.WriteLine(publisher.RaiseEvent(-14));

            Console.ReadKey();
        }
    }
}
