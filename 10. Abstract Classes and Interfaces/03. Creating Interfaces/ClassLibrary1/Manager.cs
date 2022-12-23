//child class
public class Manager: IEmployee
{
    //field
    private string _departmentName;
    private int _empID;
    private string _empName;
    private string _location;

    //properties
    public int EmpID
    {
        set
        {
            if (value >= 1000 && value <= 2000)
            {
                _empID = value;
            }
        }
        get
        {
            return _empID;
        }
    }

    public string EmpName
    {
        set
        {
            _empName = value;
        }
        get
        {
            return _empName;
        }
    }

    public string Location
    {
        set
        {
            _location = value;
        }
        get
        {
            return _location;
        }
     }


    //constructor of child class
    public Manager(int empID, string empName, string location, string departmentName)
    {
        _empID = empID;
        _empName = empName;
        _location = location;
        _departmentName = departmentName;
    }

    //method implementation of the interface methods
    public  string GetHealthInsuranceAmount()
    {
        return "Additional Health Insurance premium amount is: 1000";
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
        return DepartmentName + " at " + _location;
    }
}

