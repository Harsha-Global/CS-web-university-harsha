class Program
{
    static void Main()
    {
        //create three objects for Employee
        Employee emp1 = new Employee(); //constructor 3
        emp1.EmpID = 10;
        emp1.EmpName = "Scott";
        emp1.Job = "Manager";
        emp1.Tax = 50;
        emp1.NativePlace = "New Delhi";
        Employee emp2 = new Employee(102, "Allen"); //constructor 2
        emp2.Job = "Asst. Manager";
        Employee emp3 = new Employee(103, "Anna", "Clerk"); //constructor 1
        Employee emp4 = new Employee() { EmpName = "Ford", Job = "Executive" };

        //display fields
        System.Console.WriteLine(Employee.CompanyName);
        System.Console.WriteLine("\nFirst employee:");
        System.Console.WriteLine(emp1.EmpID);
        System.Console.WriteLine(emp1.EmpName);
        System.Console.WriteLine(emp1.Job);
        System.Console.WriteLine(emp1.Salary);
        System.Console.WriteLine(emp1.CalculateNetSalary());
        System.Console.WriteLine(emp1.NativePlace);

        //emp1.Salary = 2000;
        System.Console.WriteLine();

        System.Console.WriteLine("Second employee:");
        System.Console.WriteLine(emp2.EmpID);
        System.Console.WriteLine(emp2.EmpName);
        System.Console.WriteLine(emp2.Job);
        System.Console.WriteLine(emp2.Salary);
        System.Console.WriteLine(emp2.NativePlace);
        System.Console.WriteLine();

        System.Console.WriteLine("Third employee:");
        System.Console.WriteLine(emp3.EmpID);
        System.Console.WriteLine(emp3.EmpName);
        System.Console.WriteLine(emp3.Job);
        System.Console.WriteLine(emp3.Salary);
        System.Console.WriteLine(emp3.NativePlace);
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
}