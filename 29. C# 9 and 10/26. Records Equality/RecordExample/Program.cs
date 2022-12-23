namespace records_example
{
    public record Person(string Name, int Age, Address PersonAddress);
    public record Address(string City, string Country);

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("John", 20, new Address("London", "UK"));
            Person person2 = new Person("John", 20, person1.PersonAddress);

            Console.WriteLine($"{person1.Name}, {person1.Age}, {person1.PersonAddress.City}, {person1.PersonAddress.Country}");
            Console.WriteLine($"{person2.Name}, {person2.Age}, {person2.PersonAddress.City}, {person2.PersonAddress.Country}");
            //person1.Name = "changed"; //Error: Init-only property can only be assigned in a constructor or object initializer

            Console.Write(person1.Equals(person2)); //True
            Console.Write(person1 == person2); //True
            Console.Write(person1 != person2); //False
            //Console.Write(person1 != person1.PersonAddress); //Error
            Console.ReadKey();
        }
    }
}
