using System;
using System.Collections.Generic;
using OneToManyClass;


namespace OneToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //create a Student object
           Student student = new Student();
           student.StudentID = 100;
           student.StudentName = "George";

           student.Examinations = new List<Examination>();
           student.Examinations.Add(new Examination() { Id = 1, MarkObtained=10});
           student.Examinations.Add(new Examination() { Id=2, MarkObtained=8 });
           student.Examinations.Add(new Examination() { Id = 3, MarkObtained = 7 });


            //display the objects
            Console.WriteLine(student.StudentName + " " + student.StudentID + " ");
            Console.WriteLine("Examinations");
            foreach(Examination examination in student.Examinations)
            {
                Console.WriteLine(examination.Id + " " + examination.MarkObtained);
            }

            Console.ReadKey();

        }
    }
}
