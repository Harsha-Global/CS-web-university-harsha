namespace records_example
{
    public record Person(string Name, Address PersonAddress)
    {
        public int Age { get; set; }
    }
    public record Address(string City, string Country);

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("John", new Address("London", "UK"));
            person1.Age = 20;
            //Person person2 = person1; //reference copy
            Person person2 = person1 with { Age = 50, Name = "Scott"  }; //shallow copy
            person1.Age = 30;

            Console.WriteLine($"{person1.Name}, {person1.Age}, {person1.PersonAddress.City}, {person1.PersonAddress.Country}"); //John, 30, London, UK
            Console.WriteLine($"{person2.Name}, {person2.Age}, {person2.PersonAddress.City}, {person2.PersonAddress.Country}"); //Scott, 50, London, UK
            Console.ReadKey();
        }
    }
}
