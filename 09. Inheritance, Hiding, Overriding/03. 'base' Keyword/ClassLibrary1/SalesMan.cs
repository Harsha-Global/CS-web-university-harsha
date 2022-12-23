public class SalesMan : Employee
{
    //field
    private string _region;

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

