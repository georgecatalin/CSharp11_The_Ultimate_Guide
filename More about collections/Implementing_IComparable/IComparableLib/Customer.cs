using System;


namespace IComparableLib
{
    /// <summary>
    /// This is the model class
    /// </summary>
    public class Customer : IComparable
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public int CompareTo(object? obj)
        {
            Customer? thisCustomer = (Customer) obj;
            Console.WriteLine(this.CustomerID + " <-> " + thisCustomer.CustomerID);
            return this.CustomerID - thisCustomer.CustomerID;

   

            // return this.CustomerName.CompareTo(thisCustomer.CustomerName)  in case of strings
        }
    }
}
