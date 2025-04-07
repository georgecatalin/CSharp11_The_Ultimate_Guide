using ClassLibrary;

class Program
{
    static void Main()
    {
        Employee employee = new Employee();
        employee.EmployeeID = 1;
        employee.EmployeeName = "George";
        employee.Location = "Galati";

        System.Console.WriteLine(employee.EmployeeID);
        System.Console.WriteLine(employee.EmployeeName);
        System.Console.WriteLine(employee.Location);


        Manager manager = new Manager();
        manager.EmployeeID = 1;
        manager.EmployeeName = "Paul";
        manager.Location = "Braila";
        manager.DepartmentName = "Accounting";

        System.Console.WriteLine(manager.EmployeeID);
        System.Console.WriteLine(manager.EmployeeName);
        System.Console.WriteLine(manager.Location);

        System.Console.WriteLine(manager.DepartmentName);
        System.Console.WriteLine(manager.GetRevenueThisYear());

        System.Console.WriteLine(manager.GetCompleteDepartmentName()); // the use base to access parent's class members fields, properties, methods and constructors
        /* we use the base keyword to access members of the parent classes of better readability if there is similar naming of the fields in the child class with the parent class */

        Salesman salesman = new Salesman();
        salesman.EmployeeID = 1;
        salesman.EmployeeName = "Paul";
        salesman.Location = "Braila";
        salesman.Region = "Moldova";

        System.Console.WriteLine(salesman.EmployeeID);
        System.Console.WriteLine(salesman.EmployeeName);
        System.Console.WriteLine(salesman.Location);

        System.Console.WriteLine(salesman.Region);
        System.Console.WriteLine(salesman.GetRegion());


    }
}