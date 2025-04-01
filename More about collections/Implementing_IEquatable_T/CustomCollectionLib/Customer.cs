namespace CustomCollectionLib
{
    public class Customer : IEquatable<Customer>
    {
        public int CustomerID { get; set; }
        public required string CustomerName { get; set; }
        public TypeOfCustomer CustomerType { get; set; }

        public bool Equals(Customer? other) // reimplementing the Equals method to match for the properties instead of the reference variable pointing to the object
        {
            return this.CustomerID == other.CustomerID && this.CustomerName == other.CustomerName && this.CustomerType == other.CustomerType;
        }
    }
}
