class Program
{
    static void Main()
    {
        //loop
        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
            {
                continue;
            }
            System.Console.WriteLine(i);
        }

        System.Console.ReadKey();
    }
}