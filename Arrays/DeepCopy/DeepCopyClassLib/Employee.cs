using System;

namespace DeepCopyClassLib
{
    public class Employee : ICloneable
    {
        public string  Name { get; set; }
        public string Role { get; set; }

        public object Clone()
        {
            Employee employee = new Employee() { Name = this.Name, Role = this.Role };
            return employee;
        }
    }
}
