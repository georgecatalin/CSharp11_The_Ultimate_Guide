namespace CustomCollectionLib
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public required string CustomerName { get; set; }
        public TypeOfCustomer CustomerType { get; set; }
    }
}
