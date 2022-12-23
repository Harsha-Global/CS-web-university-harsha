class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{args.Length} values found");
        int sum = 0;
        foreach (string item in args)
        {
            if (int.TryParse(item, out int result))
            {
                sum += result;
            }
        }
        Console.WriteLine($"Total of all numbers: {sum}");
        Console.ReadKey();
    }
}

