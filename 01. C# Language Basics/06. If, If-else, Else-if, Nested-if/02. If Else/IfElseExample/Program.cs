class Program
{
    static void Main()
    {
        //declare variable to store marks of the student
        int marks = 24;

        //Print congratulations / better luck next time
        if (marks >= 35)
        {
            System.Console.WriteLine("Congratulations");
        }
        else
        {
            System.Console.WriteLine("Better luck next time");
        }

        System.Console.ReadKey();
    }
}
