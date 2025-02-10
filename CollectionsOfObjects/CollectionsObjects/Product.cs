namespace CollectionsObjects
{
    /// <summary>
    /// Stores the details about the product
    /// </summary>
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime DateOfManufacture {  get; set; }
    }
}
