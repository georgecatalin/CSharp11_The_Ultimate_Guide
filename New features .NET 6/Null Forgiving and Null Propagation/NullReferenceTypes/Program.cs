// class nameOfVariable -> this is a non-nullable type
// class? nameOfVariable -> this is a nullable type
/* C# 9 allows the possibility of a static reference type analysis providing warnings in early time to avoid null-reference errors at runtime */


namespace NullReferenceTypes
{
    public class Employee
    {
        /* we can get rid of the null warnings by either setting the default values in the properties definition or in the constructor, 
         * or setting the data type as nullable like string?
         * */


        public string FirstName { get; set; }// = "George";
        public string LastName { get; set; } // = "Calin";

        public Address Address { get; set; }

        public Employee()
        {
            FirstName = "George";
            LastName = "Calin";

        }


    }

    public class Address
    {
        public string? City { get; set; } // by default reference data types are nullable, hence there is the warning occurring. we gotta resolve it somehow
        public int Region { get; set; } // by default numeric data types are structures , and hence non-nullable by default this is why there is not a warning
    }

    public class  EmployeeBusinessLogic
    {
        public Employee? GetEmployee()
        {
            return new Employee();
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine(employee.FirstName);


            EmployeeBusinessLogic  employeeBusinessLogic = new EmployeeBusinessLogic();
            Employee? employee1 =  employeeBusinessLogic.GetEmployee();

            bool isNull = employee1 == null;

            if (isNull)
            {
                Console.WriteLine("There is a null reference here");
            }
            else
            {
                Console.WriteLine(employee1!.FirstName); // employee1! -> is ! null forgiving operator we specify to the compiler that we are sure that the variable is not null
                Console.WriteLine(employee1!.LastName);

                Console.WriteLine(employee1!.Address?.City); // Address?.City -> ?. is the null propagation operator hence employee1.Address.City returns null if the employee.Address is null.

                if (employee1!.Address != null)
                {
                    Console.WriteLine(employee1!.Address?.Region);
                }
            }

            Console.ReadKey();
        }
    }
}
