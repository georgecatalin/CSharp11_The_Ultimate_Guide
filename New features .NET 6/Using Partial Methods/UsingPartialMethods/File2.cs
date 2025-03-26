using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPartialMethods
{
    internal partial class Student
    {
        public int StudentId
        {
            get => _studentId;
            set => _studentId = value;
        }

        public partial int GetID() // this is the implementation  of the partial method in the other file
        {
            return _studentId;
        }

    }
}
