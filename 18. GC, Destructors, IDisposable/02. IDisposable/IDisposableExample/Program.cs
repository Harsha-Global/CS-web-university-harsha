using System;
using ClassLibrary1;

namespace IDisposableExample
{
    class Program
    {
        static void Main()
        {
            //create object using "using structure"
            using (Sample s = new Sample())
            {

                s.DisplayDataFromDatabase();

            }

            Console.WriteLine("Some other work here");

            Console.ReadKey();
        }
    }
}
