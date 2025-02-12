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
            //for sorting ints
            /* 
            if (x.EmployeeID != null && y.EmployeeID != null)
            {
                return x.EmployeeID - y.EmployeeID;
            }
            else
            {
                return 0;
            }
            */

            //for sorting strings
            if(x.EmployeeName != null && y.EmployeeName != null)
            {
                return x.EmployeeName.CompareTo(y.EmployeeName);
            }
            else
            {
                return 0;
            }

        }
    }
}
