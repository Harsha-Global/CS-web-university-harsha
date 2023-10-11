class Program
{
    static void Main()
    {
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Main thread";

        Console.WriteLine(mainThread.Name);
        Method1();
        Console.ReadKey();
    }

    static void Method1()
    {
        Console.WriteLine("Method 1");
    }
}
