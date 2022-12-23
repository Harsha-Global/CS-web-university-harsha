using System;
using ClassLibrary1;

namespace ValueTupleExample
{
    class Program
    {
        static void Main()
        {

            //create object
            Customer customer = new Customer();

            //get details
            (int customerID, string customerName, string email) = customer.GetCustomerDetails();

            Console.WriteLine(customerID);
            Console.WriteLine(customerName);
            Console.WriteLine(email);
            
            Console.ReadKey();
        }
    }
}
