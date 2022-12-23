using System;
class Program
{
    static void Main()
    {
        //create structure instance
        Marvel m = new Marvel("Thanos");

        //invoke the properties and methods
        Console.WriteLine(m.CharacterName);
        m.PrintCharacterName();

        Console.ReadKey();
    }
}