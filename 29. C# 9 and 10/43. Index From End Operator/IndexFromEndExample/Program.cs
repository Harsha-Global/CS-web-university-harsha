//create an array
List<string> myFriends = new List<string>() { "Scott", "Allen", "Jones", "James", "Sara" };

//traditional way
Console.WriteLine(myFriends[myFriends.Count - 1]);

//"index from end" operator (^)
Console.WriteLine(myFriends[^1]); //Sara
Console.WriteLine(myFriends[^5]); //Scott

//Index struct
Index i = ^4;
Console.WriteLine(myFriends[i]); //Scott

Console.ReadKey();

