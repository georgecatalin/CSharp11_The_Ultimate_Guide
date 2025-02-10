using System.Collections.Generic;

namespace OneToManyClass
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public List<Examination> Examinations { get; set; }
    }
}
