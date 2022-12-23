class Program
{
    static void Main()
    {
        //string
        string a = "10 0";

        //int
        int b;

        //string to int
        b = int.Parse(a);

        System.Console.WriteLine(a); //Output: "100" as string
        System.Console.WriteLine(b); //Output: 100 as int

        System.Console.ReadKey();
    }
}