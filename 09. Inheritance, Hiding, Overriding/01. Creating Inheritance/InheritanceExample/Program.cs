class Program
{
    static void Main()
    {
        //create object of Employee
        Employee emp1 = new Employee();
        emp1.EmpID = 101;
        emp1.EmpName = "Scott";
        emp1.Location = "Hyderabad";
        System.Console.WriteLine("Object of Parent class (Employee):");
        System.Console.WriteLine(emp1.EmpID);
        System.Console.WriteLine(emp1.EmpName);
        System.Console.WriteLine(emp1.Location);
        System.Console.WriteLine();

        //create object of Manager
        Manager mgr1 = new Manager();
        mgr1.EmpID = 102;
        mgr1.EmpName = "Allen";
        mgr1.Location = "New York";
        mgr1.DepartmentName = "Accounting";
        System.Console.WriteLine("Object of Child class (Manager):");
        System.Console.WriteLine(mgr1.EmpID);
        System.Console.WriteLine(mgr1.EmpName);
        System.Console.WriteLine(mgr1.Location);
        System.Console.WriteLine(mgr1.DepartmentName);
        System.Console.WriteLine(mgr1.GetTotalSalesOfTheYear());
        System.Console.WriteLine();

        //create object of SalesMan
        SalesMan salesMan1 = new SalesMan();
        salesMan1.EmpID = 103;
        salesMan1.EmpName = "John";
        salesMan1.Location = "Washington";
        salesMan1.Region = "East";
        System.Console.WriteLine("Object of Child class (SalesMan):");
        System.Console.WriteLine(salesMan1.EmpID);
        System.Console.WriteLine(salesMan1.EmpName);
        System.Console.WriteLine(salesMan1.Location);
        System.Console.WriteLine(salesMan1.Region);
        System.Console.WriteLine(salesMan1.GetSalesOfTheCurrentMonth());
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
}