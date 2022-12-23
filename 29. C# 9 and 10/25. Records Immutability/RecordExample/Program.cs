namespace records_example
{
    public record Person(string Name, int Age, Address PersonAddress);
    public record Address(string City)
    {
        public string? Country { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("John", 20, new Address("London"));
            person1.PersonAddress.Country = "UK";

            Console.WriteLine($"{person1.Name}, {person1.Age}, {person1.PersonAddress.City}, {person1.PersonAddress.Country}");
            //person1.Name = "changed"; //Error: Init-only property can only be assigned in a constructor or object initializer
            Console.ReadKey();
        }
    }
}
