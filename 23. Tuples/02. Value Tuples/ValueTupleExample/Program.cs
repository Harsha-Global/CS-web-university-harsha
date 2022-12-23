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
            (int customerID, string customerName, string email) cust = customer.GetCustomerDetails();

            Console.WriteLine(cust.customerID);
            Console.WriteLine(cust.customerName);
            Console.WriteLine(cust.email);

            Console.ReadKey();
        }
    }
}
