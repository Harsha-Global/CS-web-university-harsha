class Program
{
    static void Main()
    {
        //for loop: 0 to 9
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            System.Console.WriteLine(i);
        }

        System.Console.ReadKey();
    }
}