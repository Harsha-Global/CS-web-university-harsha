using System;

class Program
{
    static void Main()
    {
        //access static fields
        Console.WriteLine(Country.CountryName);
        Console.WriteLine(Country.NoOfStates);
        Console.WriteLine(Country.GetNoOfUnionTerritories());

        Console.ReadKey();
    }
}