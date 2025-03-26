using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPartialMethods
{
    internal partial class Student
    {
        private int _studentId;

        public partial int GetID(); // this is the declaration of the partial method in a file
    }
}
