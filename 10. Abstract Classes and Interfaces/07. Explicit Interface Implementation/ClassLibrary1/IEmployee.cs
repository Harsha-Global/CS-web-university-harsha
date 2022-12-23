//child interface
public interface IEmployee
{
    //abstract methods
    string GetHealthInsuranceAmount();
    int GetAge();

    //auto-properties
    int EmpID { set; get; }
    string EmpName { set; get; }
    string Location { set; get; }
}

