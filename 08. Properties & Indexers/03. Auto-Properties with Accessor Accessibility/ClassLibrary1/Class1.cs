public class Employee
{
    //instance fields
    private int _empID;
    private string _empName;
    private string _job;
    private double _salary;
    private double _tax;

    //instance property
    public int EmpID
    {
        set
        {
            if (value >= 100)
            {
                _empID = value;
            }
        }
        get { return _empID; }
    }

    //instance property
    public string EmpName
    {
        set { _empName = value; }
        get { return _empName; }
    }

    //instance property
    public string Job
    {
        set { _job = value; }
        get { return _job; }
    }

    //static field
    private static string _companyName;

    //static property
    public static string CompanyName
    {
        set 
        {
            if (value.Length <= 20)
            {
                _companyName = value;
            }
        }
        get { return _companyName; }
    }


    //instance constructor //constructor 1
    public Employee(int empID, string empName, string job)
    {
        this._empID = empID;
        this._empName = empName;
        this._job = job;
        this._salary = 1000;
    }

    //constructor 2
    public Employee(int empID, string empName)
    {
        this._empID = empID;
        this._empName = empName;
        this._salary = 1000;
    }

    //constructor 3
    public Employee()
    {
        _empID = 1;
        this._salary = 1000;
    }

    //static constructor
    static Employee()
    {
        _companyName = "ABC Industries";
    }

    //readonly property
    public double Salary
    {
        get
        {
            return _salary;
        }
    }

    //writeonly property
    public double Tax
    {
        set
        {
            if (value >= 0 && value <= 100)
            {
                _tax = value;
            }
        }
    }

    //method
    public double CalculateNetSalary()
    {
        double t = Salary - _tax;
        return t;
    }

    //automatic properties
    public string NativePlace { get; set; } = "New York";
}

