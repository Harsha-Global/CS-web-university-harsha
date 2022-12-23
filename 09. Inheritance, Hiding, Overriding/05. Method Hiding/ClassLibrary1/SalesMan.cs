public class SalesMan : Employee
{
    //field
    private string _region;

    //constructor of child class
    public SalesMan(int empID, string empName, string location, string region): base(empID, empName, location)
    {
        this._region = region;
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

