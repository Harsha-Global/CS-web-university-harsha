class Program
{
    static void Main()
    {
        //read input value from keyboard
        string s;
        System.Console.WriteLine("Enter a number: ");
        s = System.Console.ReadLine();

        //TryParse
        bool b = int.TryParse(s, out int n);
        if (b == true)
        {
            System.Console.WriteLine("Conversion is successful");
            System.Console.WriteLine(n);
        }
        else
        {
            System.Console.WriteLine("Conversion failed");
        }

        System.Console.ReadKey();
    }
}