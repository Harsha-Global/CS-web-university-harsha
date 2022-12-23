using System;

namespace SwitchExpressionExample
{
    class Program
    {
        static void Main()
        {
            int operation = 10; //1 to 4
            string result;

            //switch expression
            result = operation switch
            {
                1 => "Customer",
                2 => "Employee",
                3 => "Supplier",
                4 => "Distributor",
                _ => "No case available",
            };

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
