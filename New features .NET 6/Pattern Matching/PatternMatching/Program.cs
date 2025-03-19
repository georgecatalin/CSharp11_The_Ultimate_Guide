/* Through Pattern matching one can check the data type of a variable and set its value based on certain conditions */

namespace PatternMatching
{
    public class Person
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
    }


    public class Employee : Person
    {
        public double? Salary { get; set; }
    }

    public class Supplier : Person
    {
        public double? SupplierBalance { get; set; }
    }

    public class Customer : Person
    {
        public double? CustomerBalance { get; set; }
    }

    public class Manager : Employee
    {

    }


    public class Description
    {
        public static string GetDescription(Person person)
        {
            if (person.GetType() == typeof(Employee))
            {
                Employee employee = (Employee)person;
                return $"{person.Name} {person.Age} {person.Gender} {employee.Salary}";
            }
            else if (person.GetType() == typeof(Supplier))
            {
                Supplier supplier = (Supplier)person;
                return $"{person.Name} {person.Age} {person.Gender} {supplier.SupplierBalance}";
            }
            else if (person.GetType() == typeof(Customer))
            {
                Customer customer = (Customer)person;
                return $"{person.Name} {person.Age} {person.Gender} {customer.CustomerBalance}";
            }
            else
            {
                return $"{person.Name} {person.Age} {person.Gender}";
            }

        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Person person = new Person() { Name = "Mara Calin", Age = 14, Gender = "Female" };
                Console.WriteLine(Description.GetDescription(person));

                Employee employee = new Employee() { Name = "George Calin", Age = 46, Gender = "Male", Salary = 8000.6 };
                Console.WriteLine(Description.GetDescription(employee));

                Customer customer = new Customer() { Name = "Sandu Calin", Age = 70, Gender = "Male", CustomerBalance = 18000.45 };
                Console.WriteLine(Description.GetDescription(customer));

                Supplier supplier = new Supplier() { Name = "Sorina Calin", Age = 47, Gender = "Female", SupplierBalance = 7800.6 };
                Console.WriteLine(Description.GetDescription(supplier));

                Console.ReadKey();
            }
        }
    }
}

