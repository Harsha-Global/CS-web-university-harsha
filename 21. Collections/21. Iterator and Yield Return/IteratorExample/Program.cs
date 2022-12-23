using System;
using System.Collections.Generic;

namespace IteratorExample
{
    public class Sample
    {
        public List<double> Prices { get; set; } = new List<double>() { 90, 34, 12, 80 };

        //Iterator method
        public IEnumerable<double> Method()
        {
            double sum = 0;
            foreach (double price in Prices)
            {
                sum += price;
                yield return sum;  //90, 124, 136, 216
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Sample s = new Sample();
            var prices_enumerable = s.Method();
            var prices_enumerator = prices_enumerable.GetEnumerator();
            prices_enumerator.MoveNext();
            Console.WriteLine("Total price up to first product: " + prices_enumerator.Current); //90
            Console.WriteLine("Some more code....");
            prices_enumerator.MoveNext();
            Console.WriteLine("Total price up to second product: " + prices_enumerator.Current); //124
            Console.WriteLine("Some more code....");

            //foreach (var item in enumerable1)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }
    }
}
