using BankProject.DataAccessLayer.DALContracts;
using BankProject.Entities;
using BankProject.Exceptions;
using System.Collections.Generic;

namespace BankProject.DataAccessLayer
{
    public class CustomerDataAccessLayer : ICustomerDataAccessLayer
    {
        #region Fields
        List<Customer> _customers;
        #endregion

        #region Constructors
        public CustomerDataAccessLayer()
        {
            _customers = new List<Customer>();
        }
        #endregion

        #region Properties
        private List<Customer> Customers
        {

            get { return _customers; }
            set { _customers = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Return the list of all customers
        /// </summary>
        /// <returns>Returns the list of all customers</returns>
        public List<Customer> GetCustomers()
        {
            //create a new list
            List<Customer> customerList = new List<Customer>();

           Customers.ForEach(customer => customerList.Add(customer.Clone() as Customer));

           return customerList;
        }
        /// <summary>
        /// Return the set of customers that meet a certain criteria
        /// </summary>
        /// <param name="predicate">A lambda expression that incorporates a certain criters</param>
        /// <returns>Returns the list of customers that meet the condition</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            List<Customer> customerList = new List<Customer>();
            Customers.ForEach(customer => customerList.Add(customer.Clone() as Customer));

            List<Customer> filteredCustomerList = customerList.FindAll(predicate);
            return filteredCustomerList;
        }

        /// <summary>
        /// Adds a new customer to the customers lists
        /// </summary>
        /// <param name="customer">Customer object to add</param>
        /// <returns>Returns the guid of the newly created customer</returns>
        public Guid AddCustomer(Customer customer)
        {
            //generate a new Guid
            customer.CustomerId = Guid.NewGuid();

            //add the new customer to the Customers collection
            Customers.Add(customer);

            return customer.CustomerId;
        }
        /// <summary>
        /// Updates the details of an existing customer
        /// </summary>
        /// <param name="customer">The customer object whose details need to be updated</param>
        /// <returns>Returns true of the customer was updated successfully, false if the customer was not updated successfully.</returns>
        public bool UpdateCustomer(Customer customer)
        {
            //find the customer which needs to be updates
            Customer? findCustomer = Customers.Find(item => item.CustomerId == customer.CustomerId);

            if(findCustomer !=null)
            {
                findCustomer.CustomerCode = customer.CustomerCode;
                findCustomer.CustomerName = customer.CustomerName;
                findCustomer.Address = customer.Address;
                findCustomer.City = customer.City;
                findCustomer.Country = customer.Country;
                findCustomer.Landmark = customer.Landmark;
                findCustomer.Mobile = customer.Mobile;
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Deletes a customer whose customerid is provided
        /// </summary>
        /// <param name="customerid">the customerid of the customer to be deleted</param>
        /// <returns>Returns true if the deletion was successful, false if the deletion was unsuccessful</returns>
        public bool DeleteCustomer(Guid customerid)
        {
            if(Customers.RemoveAll(item => item.CustomerId == customerid) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

     
        #endregion
    }
}
