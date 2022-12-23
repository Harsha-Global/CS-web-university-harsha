using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main()
        {
            try
            {
                int a, b;
                Console.Write("Enter first number: ");
                string input1 = Console.ReadLine();
                a = int.Parse(input1);
                Console.Write("Enter second number: ");
                string input2 = Console.ReadLine();
                b = int.Parse(input2);

                int c = a / b; //DivideByZeroException will be thrown automatically
                Console.WriteLine("Result of division " + c);
            }
            catch (DivideByZeroException ex) //catching the DivideByZeroException
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
