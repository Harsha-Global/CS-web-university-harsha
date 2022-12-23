//child class
public class SalesMan : IPerson, IEmployee
{
    //field
    private string _region;
    private int _empID;
    private string _empName;
    private string _location;
    private System.DateTime _dateOfBirth;

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


    public System.DateTime DateOfBirth
    {
        set
        {
            _dateOfBirth = value;
        }
        get
        {
            return _dateOfBirth;
        }
    }

    //method
    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }

    //method
    public int GetAge()
    {
        int a = System.Convert.ToInt32((System.DateTime.Now - DateOfBirth).TotalDays / 365);
        return a;
    }
}

