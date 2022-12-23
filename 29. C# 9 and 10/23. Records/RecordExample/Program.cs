public record Person(string Name, int Age);

class Program
{
    static void Main()
    {
        Person person1 = new Person("John", 20);
        Person person2 = new("Scott", 22);
        Console.WriteLine($"{person1.Name}, {person1.Age}");
        Console.WriteLine($"{person2.Name}, {person2.Age}");
        //person1.Name = "changed"; //Error: Init-only property can only be assigned in a constructor or object initializer
        Console.ReadKey();
    }
}
