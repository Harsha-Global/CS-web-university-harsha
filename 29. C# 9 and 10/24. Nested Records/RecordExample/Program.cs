namespace records_example
{
    public record Person(string Name, int Age, Address PersonAddress);
    public record Address(string City);
    class Program
    {
        static void Main()
        {
            Person person1 = new Person("John", 20, new Address("London"));
            Person person2 = new("Scott", 22, new Address("New Delhi"));
            Console.WriteLine($"{person1.Name}, {person1.Age}, {person1.PersonAddress.City}");
            Console.WriteLine($"{person2.Name}, {person2.Age}, {person2.PersonAddress.City}");
            //person1.Name = "changed"; //Error: Init-only property can only be assigned in a constructor or object initializer
            Console.ReadKey();
        }
    }
}
