namespace CustomCollectionLlib
{
    public enum TypeOfClient
    {
        RegularClient,
        VIPClient
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public TypeOfClient CustomerType { get; set; }

    }
}
