class Program
{
    static void Main()
    {
        //create object of Manager
        Manager mgr1 = new Manager(102, "Allen", "New York", "Accounting");
        System.Console.WriteLine("Object of Child class (Manager):");
        System.Console.WriteLine(mgr1.EmpID);
        System.Console.WriteLine(mgr1.EmpName);
        System.Console.WriteLine(mgr1.Location);
        System.Console.WriteLine(mgr1.DepartmentName);
        System.Console.WriteLine(mgr1.GetTotalSalesOfTheYear());
        System.Console.WriteLine(mgr1.GetFullDepartmentName());
        System.Console.WriteLine(mgr1.GetHealthInsuranceAmount()); //Manager.GetHealthInsuranceAmount
        System.Console.WriteLine();

        //create object of SalesMan
        SalesMan salesMan1 = new SalesMan(103, "John", "Washington", "East");
        System.Console.WriteLine("Object of Child class (SalesMan):");
        System.Console.WriteLine(salesMan1.EmpID);
        System.Console.WriteLine(salesMan1.EmpName);
        System.Console.WriteLine(salesMan1.Location);
        System.Console.WriteLine(salesMan1.Region);
        System.Console.WriteLine(salesMan1.GetSalesOfTheCurrentMonth());
        System.Console.WriteLine(salesMan1.GetHealthInsuranceAmount()); //SalesMan.GetHealthInsuranceAmount
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
}

