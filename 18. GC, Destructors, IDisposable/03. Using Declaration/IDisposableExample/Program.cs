using System;
using ClassLibrary1;

namespace IDisposableExample
{
    class Program
    {
        static void DoWork()
        {
            //create object using "using declaration"
            using Sample s = new Sample();
            s.DisplayDataFromDatabase();


        } //Dispose gets called here

        static void Main()
        {
            DoWork();

            Console.WriteLine("Some other work here");

            Console.ReadKey();
        }
    }
}
