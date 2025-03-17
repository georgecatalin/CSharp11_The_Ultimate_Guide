using System;
using System.Windows.Markup;
using BankProject.Entities.Contracts;
using BankProject.Exceptions;

namespace BankProject.Entities
{
    /// <summary>
    /// Represents the Customer Model
    /// </summary>
    public class Customer : ICustomer, ICloneable
    {
        #region Private Fields
        private Guid _customerId;
        private long _customerCode;
        private string _customerName;
        private string _address;
        private string _landmark;
        private string _city;
        private string _country;
        private string _mobile;
        #endregion

        #region Public Properties
        /// <summary>
        /// Unique ID of the Customer
        /// </summary>
        public Guid CustomerId
        {
            get
            {
                return _customerId;
            }

            set
            {
                _customerId = value;
            }
        }

        /// <summary>
        /// Unique long ID for the Customer
        /// </summary>
        public long CustomerCode
        {
            get => _customerCode;
            set
            {
                if(value > 0)
                {
                    _customerCode = value;
                }
                else
                {
                    throw new CustomerException("The customer code should be > 0");
                }
            }
        }

        /// <summary>
        /// Name of the Customer
        /// </summary>
        public string CustomerName
        {
            get
            {
                return _customerName;
            }

            set
            {
                if(value.Length < 40 && string.IsNullOrEmpty(value) == false)
                {
                    _customerName = value;
                }
                else
                {
                    throw new CustomerException("The name of the customer should have less than 40 chars and it should not be null or empty string");
                }
               
            }
        }

        /// <summary>
        /// Address of the Customer
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Landmark of the customer
        /// </summary>
        public string Landmark
        {
            get
            {
                return _landmark;
            }

            set
            {
                _landmark = value;
            }
        }
        /// <summary>
        /// City of the Customer
        /// </summary>
        public string City
        {
            get
            {  
                return _city;
            }

            set
            {
                _city = value;
            }
        }
        /// <summary>
        /// Country of the Customer
        /// </summary>
        public string Country { get => _country; set => _country = value; }

        /// <summary>
        /// Mobile Number of the Customer
        /// </summary>
        public string Mobile
        {
            get
            {
                return _mobile;
            }

            set
            {
                if(value.Length == 10)
                {
                    _mobile = value;
                }
                else
                {
                    throw new CustomerException("The mobile number should only be made of 10 digits");
                }
               
            }
        }
        #endregion

        #region Methods
        public object Clone()
        {
            return new Customer()
            {
                CustomerId = this.CustomerId,
                CustomerCode = this.CustomerCode,
                CustomerName = this.CustomerName,
                Address = this.Address,
                Landmark = this.Landmark,
                City = this.City,
                Country = this.Country,
                Mobile = this.Mobile
            };
        }
        #endregion


    }
}
