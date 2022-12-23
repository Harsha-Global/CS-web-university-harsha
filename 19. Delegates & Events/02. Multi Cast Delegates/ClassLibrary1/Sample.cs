using System;

namespace ClassLibrary1
{
    public class Sample
    {
        //target method 1
        public void Add(double a, double b)
        {
            double c = a + b;
            Console.WriteLine("Addition is: " + c);
        }

        //target method 2
        public void Multiply(double a, double b)
        {
            double c = a * b;
            Console.WriteLine("Multiplication is: " + c);
        }
    }
}
