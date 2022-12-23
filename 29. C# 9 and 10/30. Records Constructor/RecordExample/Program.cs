namespace records_example
{
    public record Person(string? Name, DateTime? DateOfBirth, int? Age)
    {
        //user-defined constructor
        public Person(string? name, DateTime? dateOfBirth): this(name, dateOfBirth, null) //call to compiler-generated constructor
        {
            if (dateOfBirth is not null)
            {
                Age = Convert.ToInt32(DateTime.Now.Subtract(dateOfBirth.Value).TotalDays / 365.25);
            }
        }

        //user-defined constructor (parameter-less)
        public Person(): this(null, null, null)
        {
        }

        //user-defined method
        public string GetName()
        {
            return $"Mr./Ms. {Name}";
        }
    }

    //User --> user-defined constructor --> compiler-gen constructor

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
            Person person1 = new Person("Scott", DateTime.Parse("2001-06-04"));
            Console.WriteLine(person1);
            Console.WriteLine(person1.GetName());
            Console.ReadKey();
        }
    }
}
