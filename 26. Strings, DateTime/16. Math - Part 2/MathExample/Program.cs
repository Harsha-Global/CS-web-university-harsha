using System;

namespace MathExample
{
    class Program
    {
        static void Main()
        {
            double a = Math.Pow(10, 4); //10 power 4 (10 * 10 * 10 * 10)
            double b = Math.Min(5.623, 10.82); //smaller among given numbers
            double c = Math.Max(5.623, 10.82); //bigger among given numbers
            double d = Math.Floor(20.83984); //returns the integer part
            double e = Math.Ceiling(20.23984); //returns the next integer
            double f = Math.Round(20.23984); //round down
            double g = Math.Round(20.53984); //round up
            double h = Math.Round(20.53984, 2); //round up
            double i = Math.Sign(-10); //-1 if negative value
            double j = Math.Abs(-10); //returns positive number based on given negative number
            //10 / 3 = Quotient: 3; remainder: 1
            int rem;
            double quo = Math.DivRem(10, 3, out rem);
            double k = Math.Sqrt(25);

            Console.WriteLine(a); //Output: 10000
            Console.WriteLine(b); //Output: 5.623
            Console.WriteLine(c); //Output: 10.82
            Console.WriteLine(d); //Output: 20
            Console.WriteLine(e); //Output: 21
            Console.WriteLine(f); //Output: 20
            Console.WriteLine(g); //Output: 21
            Console.WriteLine(h); //Output: 20.54
            Console.WriteLine(i); //Output: -1
            Console.WriteLine(j); //Output: 10
            Console.WriteLine("Quotient: " + quo + ", Remainder: " + rem); //3 and 1
            Console.WriteLine(Math.Floor(Convert.ToDouble(10) / 3)); //3
            Console.WriteLine(10 % 3); //1
            Console.WriteLine(k); //5
            Console.ReadKey();
        }
    }
}
