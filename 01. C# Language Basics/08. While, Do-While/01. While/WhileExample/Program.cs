class Program
{
    static void Main()
    {
        //1 to 10
        int i = 1;
        while ( i <= 10)
        {
            System.Console.Write(i + " ");
            i++;
        }
        System.Console.WriteLine();

        //0 to 9
        i = 0;
        while (i < 10)
        {
            System.Console.Write(i + " ");
            i++;
        }
        System.Console.WriteLine();

        //9 to 0
        i = 9;
        while (i >= 0)
        {
            System.Console.Write(i + " ");
            i--;
        }

        System.Console.ReadKey();
    }
}

