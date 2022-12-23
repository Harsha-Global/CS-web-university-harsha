namespace records_example
{
    public record Person(string Name, int Age, Address PersonAddress);
    public record Address(string City, string Country)
    {
        public override string ToString()
        {
            return $"City is {City} in {Country}";
        }
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("John", 20, new Address("London", "UK"));
            Console.WriteLine(person1.ToString());
            Console.ReadKey();
        }
    }
}
