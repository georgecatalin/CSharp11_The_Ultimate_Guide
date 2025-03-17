using System;
using System.Collections.Generic;
using BankProject.Entities;
using BankProject.BusinessLogicLayer.BLLContracts;
using BankProject.Exceptions;
using BankProject.DataAccessLayer;
using BankProject.DataAccessLayer.DALContracts;

namespace BankProject.BusinessLogicLayer
{
    public class CustomerBusinessLogicLayer 
    {
        #region Private Fields
        private ICustomerDataAccessLayer _customerDataAccessLayer;
        #endregion

        #region Constructors
        public CustomerBusinessLogicLayer()
        {
            _customerDataAccessLayer = new CustomerDataAccessLayer();
        }
        #endregion

        #region Properties
        private ICustomerDataAccessLayer CustomerDataAccessLayer
        {
            get
            {
                return _customerDataAccessLayer;
            }

            set
            {
                _customerDataAccessLayer = value;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the list of all customers
        /// </summary>
        /// <returns>The list of all customers</returns>

        public List<Customer> GetCustomers()
        {
            try
            {
                //invoke DataAccessLayer
                return CustomerDataAccessLayer.GetCustomers();
            }
            catch(CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns a set of customers that specify a certain condition
        /// </summary>
        /// <param name="predicate">A lambda expression that contains a condition to check</param>
        /// <returns>The list of matching customers</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try
            {
                return CustomerDataAccessLayer.GetCustomersByCondition(predicate);
            }
            catch(CustomerException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Adds a new customer to the existing customers lists
        /// </summary>
        /// <param name="customer">The customer object to add</param>
        /// <returns>Returns the guid unique identifier generated for the new customer</returns>
        public Guid AddCustomer(Customer customer)
        {
            try
            {
                return CustomerDataAccessLayer.AddCustomer(customer);
            }
            catch(CustomerException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Updates an existing customer
        /// </summary>
        /// <param name="customer">the customer object to update</param>
        /// <returns>Returns true if the customer was updated successfully, false if the customer was not updated successfully</returns>
        public bool UpdateCustomer(Customer customer)
        {

        }

        /// <summary>
        /// Deletes the customer based on the customerID
        /// </summary>
        /// <param name="customerid">the unique identifier of the customer to be deleted</param>
        /// <returns>Returns true if the customer as deleted successfully, false if the customer was not deleted successfully   </returns>
        public bool DeleteCustomer(Guid customerid)
        {

        }
        #endregion
    }
}
