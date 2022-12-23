using System;

namespace ClassLibrary1
{
    public class Customer
    {
        public (int customerID, string customerName, string email) GetCustomerDetails()
        {
            return (101, "Scott", "scott@gmail.com");
        }
    }
}
