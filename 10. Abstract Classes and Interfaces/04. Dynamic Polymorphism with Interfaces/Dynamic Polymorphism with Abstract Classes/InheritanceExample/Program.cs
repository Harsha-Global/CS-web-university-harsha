class Program
{
    static void Main()
    {
        //create reference variable of Employee class (abstract class)
        Employee emp;

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

