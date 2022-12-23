class Program
{
    static void Main()
    {
        //create reference of parent interface (IEmployee)
        IEmployee emp;

        //create object of Manager
        emp = new Manager(102, "Allen", "New York", "Accounting");
        System.Console.WriteLine(emp.GetHealthInsuranceAmount()); //Manager.GetHealthInsuranceAmount
        System.Console.WriteLine();

        //create object of SalesMan
        emp = new SalesMan(103, "John", "Washington", "East");
        System.Console.WriteLine(emp.GetHealthInsuranceAmount()); //SalesMan.GetHealthInsuranceAmount
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
}

