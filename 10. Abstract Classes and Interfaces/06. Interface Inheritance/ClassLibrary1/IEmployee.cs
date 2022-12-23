//child interface
public interface IEmployee : IPerson
{
    //abstract methods
    string GetHealthInsuranceAmount();

    //auto-properties
    int EmpID { set; get; }
    string EmpName { set; get; }
    string Location { set; get; }
}

