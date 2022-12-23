//parent class & abstract class
public abstract class Employee
{
    //fields
    private int _empID;
    private string _empName;
    protected string _location;

    //constructor of parent class
    public Employee(int empId, string empName, string location)
    {
        this._empID = empId;
        this._empName = empName;
        this._location = location;
    }

    //virtual method
    public virtual string GetHealthInsuranceAmount()
    {
        return "Health Insurance amount is: " + 500;
    }

    //properties
    public int EmpID
    {
        set
        {
            _empID = value;
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
}
