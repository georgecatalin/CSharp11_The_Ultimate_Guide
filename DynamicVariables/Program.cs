using System;

namespace thisProgram
{

    public class Student
    {
        public string? Name { get; set; }

    }
    public class Program
    {
        static void Main()
        {
            dynamic thisvar;

            thisvar = 1;

            Console.WriteLine(thisvar);

            Console.WriteLine("*************");
            thisvar = "George";
            Console.Write(thisvar);

            thisvar = new Student() { Name = "Paul" };

            Console.WriteLine(thisvar.Name);
        }
    }
}
