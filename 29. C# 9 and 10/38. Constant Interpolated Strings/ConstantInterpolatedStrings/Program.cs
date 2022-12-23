class Example
{
    public const string BaseUrl = "http://www.example.com";
    public const string ApiUrl = $"{BaseUrl}/api";
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Example.ApiUrl);
        Console.ReadKey();
    }
}