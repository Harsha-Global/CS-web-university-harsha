class Program
{
    static void Main()
    {
        //create three objects for Employee
        Employee emp1 = new Employee(); //constructor 3
        emp1.empID = 101;
        emp1.empName = "Scott";
        emp1.job = "Manager";
        Employee emp2 = new Employee(102, "Allen"); //constructor 2
        emp2.job = "Asst. Manager";
        Employee emp3 = new Employee(103, "Anna", "Clerk"); //constructor 1
        Employee emp4 = new Employee() { empName = "Ford", job = "Executive" };

        //display fields
        System.Console.WriteLine(Employee.companyName);
        System.Console.WriteLine("\nFirst employee:");
        System.Console.WriteLine(emp1.empID);
        System.Console.WriteLine(emp1.empName);
        System.Console.WriteLine(emp1.job);
        System.Console.WriteLine();

        System.Console.WriteLine("Second employee:");
        System.Console.WriteLine(emp2.empID);
        System.Console.WriteLine(emp2.empName);
        System.Console.WriteLine(emp2.job);
        System.Console.WriteLine();

        System.Console.WriteLine("Third employee:");
        System.Console.WriteLine(emp3.empID);
        System.Console.WriteLine(emp3.empName);
        System.Console.WriteLine(emp3.job);
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
}