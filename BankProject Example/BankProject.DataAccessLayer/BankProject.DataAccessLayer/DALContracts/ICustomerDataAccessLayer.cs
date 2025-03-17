using System;
using System.Collections.Generic;
using BankProject.Entities;

namespace BankProject.DataAccessLayer.DALContracts
{
    /// <summary>
    /// An interface that represents customers data access layer
    /// </summary>
    internal interface ICustomerDataAccessLayer
    {
        /// <summary>
        /// Returns the list of all customers
        /// </summary>
        /// <returns>The list of all customers</returns>

        List<Customer> GetCustomers();

        /// <summary>
        /// Returns a set of customers that specify a certain condition
        /// </summary>
        /// <param name="predicate">A lambda expression that contains a condition to check</param>
        /// <returns>The list of matching customers</returns>
        List<Customer> GetCustomersByCondition(Predicate<Customer> predicate);

        /// <summary>
        /// Adds a new customer to the existing customers lists
        /// </summary>
        /// <param name="customer">The customer object to add</param>
        /// <returns>Returns the guid unique identifier generated for the new customer</returns>
        Guid AddCustomer(Customer customer);

        /// <summary>
        /// Updates an existing customer
        /// </summary>
        /// <param name="customer">the customer object to update</param>
        /// <returns>Returns true if the customer was updated successfully, false if the customer was not updated successfully</returns>
        bool UpdateCustomer(Customer customer);

        /// <summary>
        /// Deletes the customer based on the customerID
        /// </summary>
        /// <param name="customerid">the unique identifier of the customer to be deleted</param>
        /// <returns>Returns true if the customer as deleted successfully, false if the customer was not deleted successfully   </returns>
        bool DeleteCustomer(Guid customerid);
    }
}
