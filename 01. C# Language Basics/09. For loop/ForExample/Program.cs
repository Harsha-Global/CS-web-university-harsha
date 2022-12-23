class Program
{
    static void Main()
    {
        //1 to 10
        for (int i = 1; i <= 10; i++)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

        //0 to 9
        for (int i = 0; i < 10; i++)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

        //9 to 0
        int j = 9;
        for (; j >= 0; j--)
        {
            System.Console.Write(j + " ");
        }

        System.Console.ReadKey();
    }
}

