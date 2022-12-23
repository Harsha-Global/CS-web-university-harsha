class Employee
{
    public int x { get; set; }
}

class EmployeeBusinessLogic
{
    public Employee? GetEmployee()
    {
        return null;
    }
}
class Program
{
    static void Main()
    {
        EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
        Employee? employee = employeeBusinessLogic.GetEmployee();
        if (employee == null)
        {
            Console.WriteLine("The variable is null");
        }
        else
        {
            Console.WriteLine(employee.x);
        }
        Console.ReadKey();
    }
}

//Employee    = non-nullable (null values are not accepted)
//Employee?  = nullable (accepts null values)
