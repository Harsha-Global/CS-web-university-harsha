using System;
using System.Collections.Generic;
using System.Collections;

namespace namespace1
{
    //enum for type of customer (VIP | Regular)
    public enum TypeOfCustomer
    {
        RegularCustomer, VIPCustomer
    }

    //model class
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public TypeOfCustomer CustomerType { get; set; }
    }

    //custom collection class
    public class CustomersList : IEnumerable<Customer>
    {
        //private collection as a field
        private List<Customer> customers = new List<Customer>();

        //implementing IEnumerable.GetEnumerator()
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //implementing IEnumerable<T>.GetEnumerator()
        public IEnumerator<Customer> GetEnumerator()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                yield return customers[i]; //return and pause
            }
        }

        //Add with validations
        public void Add(Customer cust)
        {
            //validation
            if (cust.CustomerID.StartsWith("A") || cust.CustomerID.StartsWith("a"))
            {
                customers.Add(cust);
            }
            else
            {
                Console.WriteLine("Invalid Customer ID");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            CustomersList customersList = new CustomersList() {
                new Customer() { CustomerID = "A101", CustomerName = "James", Email = "james@example.com", CustomerType = TypeOfCustomer.RegularCustomer },
                new Customer() { CustomerID = "A201", CustomerName = "Bob", Email = "bob@example.com", CustomerType = TypeOfCustomer.VIPCustomer },
                new Customer() { CustomerID = "A301", CustomerName = "Alice", Email = "alice@example.com", CustomerType = TypeOfCustomer.VIPCustomer }
            }; //collection initializer (using Add() method)

            //Add
            Customer new_cust = new Customer() { CustomerID = "A456", CustomerName = "Jacob", Email = "jacob@example.com", CustomerType = TypeOfCustomer.VIPCustomer };
            customersList.Add(new_cust);

            foreach (Customer customer in customersList)
            {
                Console.WriteLine(customer.CustomerID + ", " + customer.CustomerName + ", " + customer.Email + ", " + customer.CustomerType);
            }
            Console.ReadKey();
        }
    }
}
