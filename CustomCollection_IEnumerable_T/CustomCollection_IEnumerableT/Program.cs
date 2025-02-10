using System;
using System.Collections;
using System.Collections.Generic;
using CustomCollectionLlib;


namespace CustomCollection_IEnumerableT
{
    internal class Program
    {
        static void Main()
        {
            CustomerCollection customerCollection = new CustomerCollection()
            {
                new Customer() {CustomerID = 1, CustomerName ="George", CustomerType = TypeOfClient.RegularClient },
                new Customer() {CustomerID = 2, CustomerName = "Liviu", CustomerType= TypeOfClient.VIPClient }
            };

            Customer newCustomer = new Customer();
            newCustomer.CustomerID = 100;
            newCustomer.CustomerName = "Mara";
            newCustomer.CustomerType = TypeOfClient.VIPClient;

            customerCollection.Add(newCustomer);

            foreach (Customer customer in customerCollection) Console.WriteLine(customer.CustomerName);

            Console.ReadKey();
        }
    }
}
