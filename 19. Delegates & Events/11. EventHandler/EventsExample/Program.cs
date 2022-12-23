using System;
using ClassLibrary1;

namespace EventsExample
{
    //subscriber class
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            p.DoWork();

            Console.ReadKey();
        }

        public void DoWork()
        {
            //create obj of Publisher class
            Publisher publisher = new Publisher();

            //handle the event (or) subscribe to event
            publisher.myEvent += (sender, e) =>
            {
                int c = e.a + e.b;
                Console.WriteLine(c);
            };

            //invoke the event
            publisher.RaiseEvent(this, 10, 50);
            publisher.RaiseEvent(this, -5, 30);
            publisher.RaiseEvent(this, 14, 10);
        }
    }
}
