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
            publisher.myEvent += (a, b) =>
            {
                int c = a + b;
                Console.WriteLine(c);
            };

            //invoke the event
            publisher.RaiseEvent(10, 20);
            publisher.RaiseEvent(5, 80);
            publisher.RaiseEvent(14, 22);

            Console.ReadKey();
        }
    }
}
