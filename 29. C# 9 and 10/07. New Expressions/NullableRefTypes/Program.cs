class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public AddressDetails? PersonAddressDetails { get; set; }

    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class AddressDetails
{
    public string? City { get; set; }
    public int? ZipCode { get; set; }
}

class EmployeeBusinessLogic
{
    public Employee? GetEmployee()
    {
        //return null;
        //return new Employee();
        //return new("John", "Doe"); //equivalent to new Employee("John", "Doe")
        //Employee e = new("John", "Doe");
        Employee e = new("John", "Doe");
        return e;
    }
}

class DataPrinter
{
    public static void PrintEmployee(Employee e)
    {
        if (e != null)
        {
            Console.WriteLine($"{e.FirstName} {e.LastName}");
        }
    }
}
class Program
{
    static void Main()
    {
        EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
        Employee? employee = employeeBusinessLogic.GetEmployee();

        //we are checking if it is null before the "if" statement
        bool isValid = employee == null;
        if (isValid)
        {
            Console.WriteLine("The variable is null");
        }
        else //compiler can't understand above condition that checks if the variable is null
        {
            Console.WriteLine(employee!.FirstName.ToUpper()); //!. operator (null forgiving operator) says that, the "employee" variable is NOT NULL, I'm sure.
            Console.WriteLine(employee!.LastName.ToUpper());
            Console.WriteLine(employee!.PersonAddressDetails?.City);
            Console.WriteLine(employee!.PersonAddressDetails?.ZipCode); //?. operator (null propagation operator) says that, access that "City" or "ZipCode" property ONLY if  "employee" variable is NOT NULL; otherwise, make the whole expression as null.
        }

        DataPrinter.PrintEmployee(new("one", "two")); //Employee class name will be taken automatically here, based on the definition of the PrintEmployee method

        //"new" expression works here, because we have not used "var"
        using (FileStream f = new("", FileMode.Create, FileAccess.Read))
        {

        }
        Console.ReadKey();
    }
}

//Employee    = non-nullable (null values are not accepted)
//Employee?  = nullable (accepts null values)
