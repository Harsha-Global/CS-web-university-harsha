namespace records_example
{
    public record Person(string Name, int Age, Address PersonAddress);
    public record Address(string City, string Country);

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("John", 20, new Address("London", "UK"));
            var (name, _, (city, country)) = person1;

            Console.WriteLine($"{name}, {city}, {country}"); //John, London, UK
            Console.ReadKey();
        }
    }
}
