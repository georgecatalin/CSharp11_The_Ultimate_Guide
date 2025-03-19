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
            switch (person)
            {
                case Employee employee:
                    return $"{person.Name} {person.Age} {person.Gender} {employee.Salary}";
                    break; //break is unnecessary here cause anyways control jumps out
                case Customer customer:
                    return $"{person.Name} {person.Age} {person.Gender} {customer.CustomerBalance}";
                    break;
                case Supplier supplier:
                    return $"{person.Name} {person.Age} {person.Gender} {supplier.SupplierBalance}";
                    break;
                default:
                    return $"{person.Name} {person.Age} {person.Gender}";
                    break;
            }

        }

        public static string GetDescription2(Person person)
        {
            switch (person)
            {
                case Person p when p.Age < 13:
                    return $"{p.Name} is a child";
                    break; // break is not compulsory here
                case Person p when p.Age > 13 && p.Age < 20:
                    return $"{p.Name} is a Teenager";
                    break;
                case Person p when p.Age > 20 && p.Age < 60:
                    return $"{p.Name} is an Adult";
                    break;
                case Person p when p.Age > 60:
                    return $"{p.Name} is a Senior";
                    break;
                default:
                    return $"{person.Name} is a person";
                    break;
            }
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Mara Calin", Age = 14, Gender = "Female" };
            Console.WriteLine(Description.GetDescription(person));
            Console.WriteLine(Description.GetDescription2(person));

            Employee employee = new Employee() { Name = "George Calin", Age = 46, Gender = "Male", Salary = 8000.6 };
            Console.WriteLine(Description.GetDescription(employee));
            Console.WriteLine(Description.GetDescription2(employee));

            Customer customer = new Customer() { Name = "Sandu Calin", Age = 70, Gender = "Male", CustomerBalance = 18000.45 };
            Console.WriteLine(Description.GetDescription(customer));
            Console.WriteLine(Description.GetDescription2(customer));

            Supplier supplier = new Supplier() { Name = "Sorina Calin", Age = 47, Gender = "Female", SupplierBalance = 7800.6 };
            Console.WriteLine(Description.GetDescription(supplier));
            Console.WriteLine(Description.GetDescription2(supplier));

            Console.ReadKey();
        }
    }
}


