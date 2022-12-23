using System;
using System.IO;

Console.WriteLine("Hello, World!");
string name = "Harsha";
Console.WriteLine($"Hello to {name}");
Console.ReadKey();


namespace namespace2
{
    class Sample
    {
        public void Method1()
        {
            //string str = name; //Error CS8801  Cannot use local variable or local function 'name' declared in a top-level statement in this context.
        }
    }
}

class Program2
{
    static void Main()
    {
        Console.WriteLine("my own Main method");
    }
}
