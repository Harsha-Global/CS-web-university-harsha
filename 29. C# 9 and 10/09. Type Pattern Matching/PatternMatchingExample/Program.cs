class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Gender { get; set; }
}

class Employee: Person
{
    public double? Salary { get; set; }
}

class Customer : Person
{
    public double? CustomerBalance { get; set; }
}

class Supplier : Person
{
    public double? SupplierBalance { get;set; }
}

class Manager : Employee
{
}

class Descripter
{
    public static string GetDescription(Person person)
    {
        if (person is Employee emp)
        {
            return $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}";
        }
        else if (person is Customer cst)
        {
            return $"{person.Name}, {person.Age}, {person.Gender}, {cst.CustomerBalance}";
        }
        else if (person is Supplier sup)
        {
            return $"{person.Name}, {person.Age}, {person.Gender}, {sup.SupplierBalance}";
        }
        else
            return $"{person.Name}, {person.Age}, {person.Gender}";
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager() {  Name = "John", Gender = "Male", Age = 20, Salary = 3000 };
        Customer customer = new Customer() { Name = "Smith", Gender = "Male", Age = 30, CustomerBalance = 1000 };
        Console.WriteLine(Descripter.GetDescription(manager));
        Console.ReadKey();
    }
}

