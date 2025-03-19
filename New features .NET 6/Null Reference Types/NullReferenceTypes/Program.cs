// class nameOfVariable -> this is a non-nullable type
// class? nameOfVariable -> this is a nullable type
/* C# 9 allows the possibility of a static reference type analysis providing warnings in early time to avoid null-reference errors at runtime */


namespace NullReferenceTypes
{
    public class Employee
    {
        public int x { get; set; }
    }

    public class  EmployeeBusinessLogic
    {
        public Employee? GetEmployee()
        {
            return null; ;
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { x = 125 };
            Console.WriteLine(employee.x);


            EmployeeBusinessLogic  employeeBusinessLogic = new EmployeeBusinessLogic();
            Employee? employee1 =  employeeBusinessLogic.GetEmployee();

            if (employee1 == null)
            {
                Console.WriteLine("There is a null reference here");
            }
            else
            {
                Console.WriteLine(employee1.x);
            }

            Console.ReadKey();
        }
    }
}
