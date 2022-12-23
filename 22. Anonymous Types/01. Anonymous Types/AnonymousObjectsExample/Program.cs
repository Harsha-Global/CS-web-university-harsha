using System;
using ClassLibrary1;

namespace AnonymousObjectsExample
{
    class Program
    {
        static void Main()
        {
            //create object of Person class
            Person p = new Person();

            //call Methods
            var person = new { PersonName = p.GetPersonName(), Age = p.GetPersonAge() };

            //print
            Console.WriteLine(person.PersonName);
            Console.WriteLine(person.Age);

            Console.ReadKey();
        }
    }
}
