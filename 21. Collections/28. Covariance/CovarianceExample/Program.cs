using System;
using System.Collections.Generic;

namespace CovarianceExample
{
    class LivingThing
    {
        public int NumberOfLegs { get; set; }
    }

    class Parrot: LivingThing
    {
    }

    class Dog: LivingThing
    {
    }

    interface IMover<out T>
    {
        T Move();
    }
    class Mover<T>: IMover<T>
    {
        public T thing { get; set; }
        public T Move()
        {
            return thing;
        }
    }

    class Sample
    {
        public void PrintValues(IEnumerable<object> values)
        {
            foreach (var item in values)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main()
        {
            //create object
            LivingThing livingThing = new Parrot(); //not covariance
            Parrot parraot = new Parrot() { NumberOfLegs = 2 }; //normal

            // Covariance = supply the child type name, where the parent type name is expected.
            IMover<LivingThing> mover = new Mover<Parrot>() { thing = parraot };  
            Console.WriteLine("Moving with " + mover.Move().NumberOfLegs + " legs"); //"LivingThing" vs "Parrot"; supplying the child type (Parrot), where the parent type (LivingThing) is expected


            //Covariance in real life
            Sample s = new Sample();
            s.PrintValues(new List<string>() { "hello", "world" });

            Console.ReadKey();
        }
    }
}
