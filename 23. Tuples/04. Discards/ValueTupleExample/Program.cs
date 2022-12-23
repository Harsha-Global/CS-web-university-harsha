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
            (int customerID, _, string email) = customer.GetCustomerDetails();

            Console.WriteLine(customerID);
            Console.WriteLine(email);
            
            Console.ReadKey();
        }
    }
}
