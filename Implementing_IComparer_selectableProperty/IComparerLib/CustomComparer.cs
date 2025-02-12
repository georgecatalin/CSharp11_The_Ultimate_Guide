using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerLib
{
    public class CustomComparer : IComparer<Employee>
    {
        public TypeOfSort SortType { get; set; }



        public int Compare(Employee? x, Employee? y)
        {
            int result;

           switch(this.SortType)
            {
                case TypeOfSort.EmployeeID:
                    result = x.EmployeeID - y.EmployeeID;
                    break;
                case TypeOfSort.EmployeeName:
                    result  = (x.EmployeeName != null) ? x.EmployeeName.CompareTo(y.EmployeeName) : 0;
                    break;
                case TypeOfSort.EmployeeJob: 
                    result = (x.EmployeeJob != null) ? x.EmployeeJob.CompareTo(y.EmployeeJob) : 0 ;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }
    }
}
