using System.Diagnostics.CodeAnalysis;

public class Person
{
  public required string Name { get; set; }
  public int Age { get; set; }

  [SetsRequiredMembers]
  public Person()
  {
    Name = "Unknown";
  }

  [SetsRequiredMembers]
  public Person(string personName)
  {
    Name = personName;
  }
}

