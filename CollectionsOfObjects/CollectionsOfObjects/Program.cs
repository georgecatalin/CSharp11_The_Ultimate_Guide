using System;
using System.Collections.Generic;
using CollectionsObjects;


namespace CollectionsOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a collection of objects
            List<Product> products = new List<Product>();

            //add elements to the collection of objects by reading from the keyboard
            string choice = "" ;

            do
            {
                Console.WriteLine("Enter the product ID");
                int pid = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the product name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the price ");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the date of manufacture in the format YYYY-MM-DD");
                DateTime date = DateTime.Parse(Console.ReadLine());

                //create the object
                Product product = new Product() { ProductID = pid, ProductName=name, Price = price, DateOfManufacture =date };

                //add the objeect to the collection
                products.Add(product);

                Console.WriteLine("The following product has been added ->" + product.ProductID);

                //decide if user wants to add another object
                Console.WriteLine("Do you wish to add another object");

                choice = Console.ReadLine();

            } while (choice != "NO" && choice != "no" && choice != "n" && choice !="N");

            Console.WriteLine("The collection of objects contains:");
            foreach (Product product in products) {
                Console.WriteLine(product.ProductName + " , " + product.ProductID + " , " + product.Price + " , " + product.DateOfManufacture.ToShortDateString);
                    };

            Console.ReadKey();
        }
    }
}
