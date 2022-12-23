namespace record_structs_example
{
    //public readonly record struct Person(string? Name, int? Age);
    public record struct Person(string? Name, int? Age);

    class Program
    {
        static void Main()
        {
            Person person = new Person("Jaxon", 30);
            //ToString(), Deconstruct(), Equals()
            Console.WriteLine(person.ToString());

            Person person2 = person;
            person.Age = 40; //will not effect the other struct variable (person2)
            Console.WriteLine(person2.ToString()); //Age as 30

            Console.ReadKey();
        }
    }
}