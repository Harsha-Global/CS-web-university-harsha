using System;

namespace ImplicitlyTypedVariablesExample
{
    class Program
    {
        static void Main()
        {
            var p = new namespace1.namespace2.namespace3.Person() { PersonName = "Harsha" };
            var p2 = "Harsha".ToUpper();

            Console.WriteLine(p.PersonName);
            Console.WriteLine(p2);
            Console.ReadKey();
        }
    }
}
