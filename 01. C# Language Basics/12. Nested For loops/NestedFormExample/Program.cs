class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                System.Console.Write(j);
                System.Console.Write(" ");
            }
            System.Console.WriteLine();
        }

        System.Console.ReadKey();
    }
}


