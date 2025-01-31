namespace ExpressionBodyClass
{
    public class Student
    {
        //private field
        private string _studentName;

        //use expression body member with method of a single line
        public int GetNameLength() => _studentName.Length;

        //use expression body member with constructor
        public Student(string studentName) => _studentName = studentName;

        // use expression body member with properties
        public string StudentName
        {
            set => _studentName = value;
            get => _studentName;
        }
    }
}
