class Program
{
    static void Main()
    {
        //int
        int a = 1000;

        //string
        string b;

        //int --> string
        b = System.Convert.ToString(a);

        System.Console.WriteLine(a); //Output: 1000 as int
        System.Console.WriteLine(b); //Output: 1000 as string
        System.Console.ReadKey();
    }
}