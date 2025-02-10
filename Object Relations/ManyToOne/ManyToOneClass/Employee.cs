

namespace ManyToOneClass
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public Department Department { get; set; }
    }
}
