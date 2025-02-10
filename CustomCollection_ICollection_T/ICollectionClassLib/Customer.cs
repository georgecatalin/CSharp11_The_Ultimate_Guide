using System;
using System.Collections;
using System.Collections.Generic;


namespace ICollectionClassLib
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public required string CustomerName { get; set; }
        public TypeOfCustomer CustomerType { get; set; }

    }
}
