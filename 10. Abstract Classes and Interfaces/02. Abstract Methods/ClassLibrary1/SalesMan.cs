//child class
public class SalesMan : Employee
{
    //field
    private string _region;

    //constructor of child class
    public SalesMan(int empID, string empName, string location, string region): base(empID, empName, location)
    {
        this._region = region;
    }

    //method overriding the abstract methods
    public override string GetHealthInsuranceAmount()
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

