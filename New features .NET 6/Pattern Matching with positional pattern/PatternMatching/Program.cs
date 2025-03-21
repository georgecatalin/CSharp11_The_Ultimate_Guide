/* Whenever you need to check the same properties in the same order in multiple places of the code, one can use positional pattern */

namespace PatternMatching
{

    public enum MaritalStatus
    {
        Married = 0,
        Unmarried = 1
    }
    public class Person
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public MaritalStatus StatusMarital { get; set; }
        /// <summary>
        /// This deconstruct method will be automatically appealed to in the switch expression the enumerate the properties which need to be verified in the certain order
        /// </summary>
        /// <param name="person"></param>
        /// <param name="age"></param>
        /// <param name="statusmarital"></param>
        /// <param name="gender"></param>
        public void Deconstruct(out Person person, out int? age, out MaritalStatus statusmarital, out string? gender)
        {
            person = this;
            age = this.Age;
            statusmarital = this.StatusMarital;
            gender = this.Gender;

            //or the same can be written as
            // (person, age, statusmarital, gender) = (this, this.Age, this.StatusMarital, this.Gender)
        }
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
        /// <summary>
        /// Rewrite this method using pattern matching with property matching and a single property
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static string GetDescription2(Person person)
        {
            string result = person switch
            {
                Person {Age: < 13 } p => $"{p.Name} is nothing , but a child",
                Person {Age: >= 13 and  < 20 } p => $"{p.Name} is a teenager",
                Person {Age: >= 20 and  < 60 } p => $"{p.Name} is an adult",
                Person {Age: > 60 } p  => $"{p.Name} is a senior.",
                _ => $"{person.Name} is a person."
            };

            return result;
        }
        /// <summary>
        /// Write an example of pattern matching using positional pattern
        /// <param name="person"></param>
        /// <returns></returns>
        public static string GetDescription3(Person person)
        {
            //Mr, Mrs, Ms
            return person switch // person will be deconstructed automatically in the tuple as defined through the Deconstruct() method earlier
            {
                (Person,<13,_,_)=> "It does not apply",
                (Person,>18,MaritalStatus.Married,"Female") => "Mrs",
                (Person,>18,MaritalStatus.Married,"Male")=>"Mr.",
                _=>"I do not know how to take it"
            };
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Mara Calin", Age = 14, Gender = "Female", StatusMarital = MaritalStatus.Unmarried };
            Console.WriteLine(Description.GetDescription(person));
            Console.WriteLine(Description.GetDescription2(person));
            Console.WriteLine(Description.GetDescription3(person));

            Employee employee = new Employee() { Name = "George Calin", Age = 46, Gender = "Male", Salary = 8000.6 , StatusMarital = MaritalStatus.Married };
            Console.WriteLine(Description.GetDescription(employee));
            Console.WriteLine(Description.GetDescription2(employee));
            Console.WriteLine(Description.GetDescription3(employee));

            Customer customer = new Customer() { Name = "Sandu Calin", Age = 70, Gender = "Male", CustomerBalance = 18000.45, StatusMarital = MaritalStatus.Married };
            Console.WriteLine(Description.GetDescription(customer));
            Console.WriteLine(Description.GetDescription2(customer));
            Console.WriteLine(Description.GetDescription3(customer));

            Supplier supplier = new Supplier() { Name = "Sorina Calin", Age = 47, Gender = "Female", SupplierBalance = 7800.6, StatusMarital = MaritalStatus.Married };
            Console.WriteLine(Description.GetDescription(supplier));
            Console.WriteLine(Description.GetDescription2(supplier));
            Console.WriteLine(Description.GetDescription3(supplier));

            Console.ReadKey();
        }
    }
}


