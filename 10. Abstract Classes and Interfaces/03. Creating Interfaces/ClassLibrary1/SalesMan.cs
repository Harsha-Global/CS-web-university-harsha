//child class
public class SalesMan : IEmployee
{
    //field
    private string _region;
    private int _empID;
    private string _empName;
    private string _location;

    //properties
    public int EmpID
    {
        set
        {
            if (value >= 500 && value < 1000)
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
    public SalesMan(int empID, string empName, string location, string region)
    {
        this._empID = empID;
        this._empName = empName;
        this._location = location;
        this._region = region;
    }

    //method implementation of the interface methods
    public string GetHealthInsuranceAmount()
    {
        return "Additional Health Insurance premium amount is: 500";
    }

    //property
    public string Region
    {
        set
        {
            _region = value;
        }
        get
        {
            return _region;
        }
    }

    //method
    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }
}

