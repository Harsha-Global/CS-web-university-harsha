using System;
using ClassLibrary1;

namespace EventsExample
{
    class Program
    {
        static void Main()
        {
            //create obj of Subscriber class
            Subscriber subscriber = new Subscriber();

            //create obj of Publisher class
            Publisher publisher = new Publisher();

            //handle the event (or) subscribe to event
            publisher.myEvent += subscriber.Add;

            //invoke the event
            publisher.RaiseEvent(10, 20);

            Console.ReadKey();
        }
    }
}
