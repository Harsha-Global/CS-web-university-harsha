/*
{
  "name": "John Doe",
  "age": 35
}
*/
string json = "{\r\n  \"name\": \"John Doe\",\r\n  \"age\": 35\r\n}";
Console.WriteLine(json);

string json1 = """   
  {  
  "name": "John Doe",
    "age": 35
}
""";
Console.WriteLine(json1);

string name = "Alice";
int age = 25;
string message = $"""""  
  Hello, {name}, 
   age """" is {age}
  """"";
Console.WriteLine(message);

Console.ReadKey();