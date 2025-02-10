using System;
using System.Collections.Generic;
using System.Collections;


namespace CustomCollectionsClassLib
{
    public enum TypeOfCustomer
    {
        RegularCustomer,
        VIPCustomer
    }


    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; }
        public TypeOfCustomer CustomerType { get; set; }
    }
}
