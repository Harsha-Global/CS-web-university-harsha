public class Manager: Employee
{
    //field
    private string _departmentName;

    //constructor of child class
    public Manager(int empID, string empName, string location, string departmentName) : base(empID, empName, location)
    {
        _departmentName = departmentName;
    }

    //method hiding
    public new string GetHealthInsuranceAmount()
    {
        return "Health Insurance premium amount is: 1500";
    }

    //property
    public string DepartmentName
    {
        set
        {
            _departmentName = value;
        }
        get
        {
            return _departmentName;
        }
    }

    //method
    public long GetTotalSalesOfTheYear()
    {
        return 10000;
    }

    //method
    public string GetFullDepartmentName()
    {
        return DepartmentName + " at " + base._location;
    }
}

