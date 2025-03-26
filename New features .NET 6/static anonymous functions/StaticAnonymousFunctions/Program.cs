namespace StaticAnonymousFunctions
{
    public class Student
    {
        public int ID { get; set; }
        public List<int> Marks { get; set; }
        
    }

    public class Teacher
    {
        public static int _minimumMarkCondition = 35;

        private int minimumMarkCondition = 35;
        //the passing mark condition is >= 35
        public void GetPassedMarks(Student student)
        {
            IEnumerable<int> passedMarks = student.Marks.Where(static (int mark) =>
            {
                if (mark >= _minimumMarkCondition) // the anonymous function can access parameters, variables and instance properties, whilst the static anonymous function can only access static members of the class or constants
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            foreach (int mark in passedMarks)
            {
                Console.WriteLine(mark);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                ID = 125,
                Marks = new List<int>() { 25,40,55,36,78,96}
            };

            Teacher teacher = new Teacher();
            teacher.GetPassedMarks(student);

            Console.ReadKey();
        }
    }
}
