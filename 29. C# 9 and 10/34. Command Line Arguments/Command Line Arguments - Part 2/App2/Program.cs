//args[0] is a file path
if (args.Length == 1)
{
    if (File.Exists(args[0]))
    {
        string content = File.ReadAllText(args[0]);
        Console.WriteLine(content);

    }
    else
    {
        Console.WriteLine("File not found");
    }
}
else
{
    Console.WriteLine("File path is expected");
}

Console.ReadKey();