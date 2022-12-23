class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public AddressDetails? PersonAddressDetails { get; set; }

    public Employee()
    {
        FirstName = "default string";
        LastName = "default string";
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
        return new Employee();
    }
}
class Program
{
    static void Main()
    {
        EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
        Employee? employee = employeeBusinessLogic.GetEmployee();

        bool isValid = employee == null;
        if (isValid)
        {
            Console.WriteLine("The variable is null");
        }
        else
        {
            Console.WriteLine(employee!.FirstName.ToUpper());
            Console.WriteLine(employee!.LastName.ToUpper());
            Console.WriteLine(employee!.PersonAddressDetails?.City);
            Console.WriteLine(employee!.PersonAddressDetails?.ZipCode);
        }
        Console.ReadKey();
    }
}

//Employee    = non-nullable (null values are not accepted)
//Employee?  = nullable (accepts null values)
