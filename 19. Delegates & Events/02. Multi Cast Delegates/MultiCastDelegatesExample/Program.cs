using System;
using ClassLibrary1;

namespace MultiCastDelegatesExample
{
    class Program
    {
        static void Main()
        {
            //create object of Sample
            Sample s = new Sample();

            //create reference variable of MyDelegateType
            MyDelegateType myDelegate;

            //add ref of first target method
            myDelegate = s.Add;

            //add ref of second target method
            myDelegate += s.Multiply;

            //invoke both target methods; first Add method; and then Multiply method
            myDelegate.Invoke(40, 10);

            Console.ReadKey();
        }
    }
}
