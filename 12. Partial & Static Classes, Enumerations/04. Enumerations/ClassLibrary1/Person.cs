public class Person
{
    public string PersonName { get; set; }
    public string Email { get; set; }
    public AgeGroupEnumeration AgeGroup { get; set; }
}

public enum AgeGroupEnumeration : short
{
    Child,
    Teenager,
    Adult = 100,
    Senior
}

