using System;
using OneToOneClass;

namespace OneToOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a student object
            Student student = new Student();
            student.StudentID = 1;
            student.Name = "Andrei";

            //Create a branch object
            Branch branch = new Branch();
            branch.Name = "Computer Science";
            branch.Code = 1;

            //add the branch reference variable to the student object
            student.Branch = branch;


            //another version
            Student student2 = new Student();
            student2.StudentID = 2;
            student2.Name = "George";

            student2.Branch = new Branch();
            student2.Branch.Name = "Chemistry";
            student2.Branch.Code = 2;


            //print the objects
            Console.WriteLine(student.StudentID + " " + student.Name+ " " + student.Branch.Name + " " + student.Branch.Code);
            Console.WriteLine(student2.StudentID + " " + student2.Name + " " + student2.Branch.Name + " " + student2.Branch.Code);

            Console.ReadKey();
        }
    }
}
