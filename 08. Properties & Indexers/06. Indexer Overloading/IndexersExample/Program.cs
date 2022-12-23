class Program
{
    static void Main()
    {
        //create an object of Car class
        Car c = new Car();

        //call get accessor of indexer
        System.Console.WriteLine(c[0]); //Output: BMW
        System.Console.WriteLine(c["first"]); //Output: BMW

        //call set accessor of index
        c[0] = "Nissan";
        System.Console.WriteLine(c[0]); //Output: Nissan

        System.Console.ReadKey();
    }
}


