using System;
using System.Text.RegularExpressions;

namespace RegExpExample
{
    class Program
    {
        static void Main()
        {
            Regex regex = new Regex("^[A-Za-z ]*$");
            Console.WriteLine("Enter a name: ");
            string inputValue = Console.ReadLine();
            bool result = regex.IsMatch(inputValue);
            Console.WriteLine(result);
            if (result == true)
            {
                Console.WriteLine("Valid name");
            }
            else
            {
                Console.WriteLine("Invalid name");
            }
            Console.ReadKey();
        }
    }
}
