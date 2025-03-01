using System;
using System.IO;
using System.Text.Json;


namespace JSONSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create the object whose state to be serialized into json
            Customer customer = new Customer() { Id = 125, Name = "George", Age = 46 };

            //serialize the object
            string json = JsonSerializer.Serialize<Customer>(customer);

            Console.WriteLine($"the serialized data from object state is -> {json}");

            string filePath = @"E:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\practice_here\json.txt";
            StreamWriter streamwriter = new StreamWriter(filePath);
            streamwriter.Write(json);
            streamwriter.Close();

            //deserialize the json data to new object state
            StreamReader streamReader = new StreamReader(filePath);
            string jsonRead = streamReader.ReadToEnd();

            Customer? customer_state_read_from_file = JsonSerializer.Deserialize<Customer>(jsonRead);

            if (customer_state_read_from_file != null)
            {
                Console.WriteLine($"Deserialized Customer: Id={customer_state_read_from_file.Id}, Name={customer_state_read_from_file.Name}, Age={customer_state_read_from_file.Age}");
            }
            else
            {
                Console.WriteLine("Deserialization failed.");
            }

            Console.WriteLine("\nDeserialization done");


            Console.ReadKey();
        }
    }
}
