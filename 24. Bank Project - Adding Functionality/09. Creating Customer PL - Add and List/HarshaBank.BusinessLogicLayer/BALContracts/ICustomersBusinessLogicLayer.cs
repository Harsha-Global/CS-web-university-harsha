using System;
using System.Collections.Generic;
using HarshaBank.Entities;

namespace HarshaBank.BusinessLogicLayer.BALContracts
{
    /// <summary>
    /// Interface that represents customers business logic
    /// </summary>
    public interface ICustomersBusinessLogicLayer
    {
        // <summary>
        /// Returns all existing customers
        /// </summary>
        /// <returns>List of customers</returns>
        List<Customer> GetCustomers();

        /// <summary>
        /// Returns a set of customers that matches with specified criteria
        /// </summary>
        /// <param name="predicate">Lamdba expression that contains condition to check</param>
        /// <returns>The list of matching customers</returns>
        List<Customer> GetCustomersByCondition(Predicate<Customer> predicate);

        /// <summary>
        /// Adds a new customer to the existing customers list
        /// </summary>
        /// <param name="customer">The customer object to add</param>
        /// <returns>Returns true, that indicates the customer is added successfully
        /// </returns>
        Guid AddCustomer(Customer customer);

        /// <summary>
        /// Updates an existing customer
        /// </summary>
        /// <param name="customer">Customer object that contains customer details to update</param>
        /// <returns>Returns true, that indicates the customer is updated successfully</returns>
        bool UpdateCustomer(Customer customer);

        /// <summary>
        /// Deletes an existing customer
        /// </summary>
        /// <param name="customerID">CustomerID to delete</param>
        /// <returns>Returns true, that indicates the customer is deleted successfully</returns>
        bool DeleteCustomer(Guid customerID);
    }
}
