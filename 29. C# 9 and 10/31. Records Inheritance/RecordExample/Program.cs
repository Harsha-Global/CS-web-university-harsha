namespace records_example
{
    public interface IPerson
    {
        string? Name { get; init; }
    }
    public abstract record Person(string? Name, DateTime? DateOfBirth, int? Age): IPerson
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

    public sealed record Employee(string? Name, DateTime? DateOfBirth, double? Salary) : Person(Name, DateOfBirth);
    
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee("William", DateTime.Parse("1995-04-06"), 6000);
            Console.WriteLine(emp);
            Console.ReadKey();
        }
    }
}
