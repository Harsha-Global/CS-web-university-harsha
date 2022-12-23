using System;

class Program
{
    static void Main()
    {
        //create object of Person class
        Person person = new Person();
        person.PersonName = "John";
        person.Email = "john@gmail.com";
        person.AgeGroup = AgeGroupEnumeration.Adult;

        Console.WriteLine(person.AgeGroup);
        Console.ReadKey();
    }
}

