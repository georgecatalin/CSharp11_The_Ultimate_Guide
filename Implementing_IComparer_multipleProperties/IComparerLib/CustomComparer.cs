using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerLib
{
    public class CustomComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            int result = 0;

            if(x.EmployeeJob != null)
            {
                result = x.EmployeeJob.CompareTo(y.EmployeeJob);

                if(x.EmployeeName != null)
                {
                    result = x.EmployeeName.CompareTo(y.EmployeeName);
                }
            }

            return result;
        }
    }
}
