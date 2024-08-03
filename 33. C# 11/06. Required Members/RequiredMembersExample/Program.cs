//Person person = new Person() { Name = "Scott" };
//Person person = new Person(); //compile time error if [SetsRequiredMembers] attribute is not added
Person person = new Person(null); //compile time error

Console.WriteLine($"Name: {person.Name}");

Console.ReadKey();
