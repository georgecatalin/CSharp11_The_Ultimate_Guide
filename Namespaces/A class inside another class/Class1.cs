namespace InnerClass
{
    public class Student
    {
        public int SecuredMarks { get; set; }
        public int MaxMarks { get; set; }
        public double Percentage { get; set; }
    }


    public class OuterClass
    {
        InnerClass ic = new InnerClass();
        public int CalculatePercentage(Student student)
        {
            return student.SecuredMarks / ic.Multiply(student.MaxMarks, 100);
        }

        public class InnerClass
        {
            public int Multiply(int n1, int n2)
            {
                return n1 + n2;
            }
        }
    }
}