enum MaritalStatus
{
    Unmarried, Married
}
class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Gender { get; set; }
    public MaritalStatus PersonMartialStatus { get; set; }
}

class Employee : Person
{
    public double? Salary { get; set; }
}

class Customer : Person
{
    public double? CustomerBalance { get; set; }
}

class Supplier : Person
{
    public double? SupplierBalance { get; set; }
}

class Manager : Employee
{
}

class Descripter
{
    public static string GetDescription(Person person)
    {
        switch (person)
        {
            //if the object is of Employee or any of its child type
            case Employee emp:
                return $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}";

            //if the object is of Customer or any of its child type
            case Customer cst:
                return $"{person.Name}, {person.Age}, {person.Gender}, {cst.CustomerBalance}";

            //if the object is of Supplier or any of its child type
            case Supplier sup:
                return $"{person.Name}, {person.Age}, {person.Gender}, {sup.SupplierBalance}";

            default:
                return $"{person.Name}, {person.Age}, {person.Gender}";
        }
    }

    public static string GetDescription2(Person person)
    {
        string result = person switch
        {
            Person { Age: < 13 } p => $"{p.Name} is Child", //p.Age < 13
            Person { Age: < 20 and >= 13 } p => $"{p.Name} is a Tennager", //p.Age < 20 && p.Age >= 13
            Person { Age: >= 20 and < 60 } p  => $"{p.Name} is Adult", //p.Age >= 20 && p.Age < 60
            Person { Age: >= 60 and not (100 or 200) } p => $"{p.Name} is a senior citizen", //p.Age >= 60 && p.Age != 100 && p.Age != 200
            Person { Age: 100 or 200 }  p  => $"{p.Name} is Centenarian", //p.Age == 100 || p.Age == 200
            _ => $"{person.Name} is a person"
        };
        return result;
    }

    public static string GetDescription3(Person person)
    {
        //Master, Mr, Miss, Mrs, Mx
        return (person, person.Gender, person.Age, person.PersonMartialStatus) switch
        {
            (Person, "Female", _, MaritalStatus.Unmarried) => $"Miss. {person.Name}", //person.Gender == "Female" && person.PersonMartialStatus == MartialStatus.Unmarried
            (Person, "Female", _, MaritalStatus.Married) => $"Mrs. {person.Name}", //person.Gender == "Female" && person.PersonMartialStatus == MartialStatus.Married
            (Person, "Male", < 18, _) => $"Master. {person.Name}", //person.Gender == "Male" && person.Age < 18
            (Person, "Male", >= 18, _) => $"Mr. {person.Name}", //person.Gender == "Male" && person.Age >= 18
            (Person, not ("Male" or "Female"), _, _) => $"Mx. {person.Name}", //person.Gender != "Male" && person.Gender != "Female"
            _ => $"{person.Name}"
        };
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager() { Name = "John", Gender = "Male", Age = 100, Salary = 3000, PersonMartialStatus = MaritalStatus.Married };
        Customer customer = new Customer() { Name = "Smith", Gender = "Male", Age = 30, CustomerBalance = 1000, PersonMartialStatus = MaritalStatus.Unmarried };
        //Console.WriteLine(Descripter.GetDescription(manager));
        //Console.WriteLine(Descripter.GetDescription2(manager));
        Console.WriteLine(Descripter.GetDescription3(manager));
        Console.ReadKey();
    }
}

