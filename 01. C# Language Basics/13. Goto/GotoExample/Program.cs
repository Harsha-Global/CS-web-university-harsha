class Program
{
    static void Main()
    {
        int i = 1;
        System.Console.WriteLine("USA");
        System.Console.WriteLine("UK");
        System.Console.WriteLine("India");
        mylabel:
        System.Console.WriteLine("France");
        System.Console.WriteLine("Italy");
        System.Console.WriteLine("Iran");
        i++;
        if (i <=5)
        {
            goto mylabel;
        }
        System.Console.WriteLine("Nepal");
        System.Console.WriteLine("Dubai");

        System.Console.ReadKey();
    }
}


