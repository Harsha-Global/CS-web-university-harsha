class Program
{
    static void Main()
    {
        //primitive variable
        int x = 10;

        //boxing (value-type to reference-type)
        object obj = x;

        System.Console.WriteLine(x); //Output: 10
        System.Console.WriteLine(obj); //Output: 10
        System.Console.ReadKey();
    }
}


