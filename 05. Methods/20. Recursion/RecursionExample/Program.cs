class Sample
{
    public double Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        //read number from keyboard
        System.Console.WriteLine("Enter a number: ");
        int n = int.Parse(System.Console.ReadLine());

        //create object
        Sample s = new Sample();

        //call Factorial method
        double fact = s.Factorial(n);
        System.Console.WriteLine("Factorial of " + n + " is " + fact);
        System.Console.ReadKey();

        //n = 5
        //Factorial(5) = 5 * Factorial(4)
        //Factorial(4) = 4 * Factorial(3)
        //Factorial(3) = 3 * Factorial(2)
        //Factorial(2) = 2 * Factorial(1)
        //Factorial(1) = 1 * Factorial(0)
        //Factorial(0) = 1
    }
}