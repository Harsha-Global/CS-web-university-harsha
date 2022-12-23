class Program
{
    static void Main()
    {
        var getMessage = () => "Hello World";

        //scenario 1
        Func<int, object> getResult = object (marks) =>
        {
            if (marks >= 35)
                return "Pass";
            else
                return 0;
        };
        Console.WriteLine(getResult(50));

        //scenario 2
        var GetNumbers = IList<int> () => new int[] { 10, 20, 30 };
        var result = GetNumbers();
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}
