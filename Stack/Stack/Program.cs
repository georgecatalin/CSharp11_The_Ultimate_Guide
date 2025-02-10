using System;
using System.Collections.Generic;


namespace Stack
{
    internal class Student
    {
        public int Mark { get; set; }
        public int Rank { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Stack object
            Stack<Student> student = new Stack<Student>();

            //Add an element to the stack
            student.Push(new Student() { Mark =5});
            student.Push(new Student() { Mark = 6 });
            student.Push(new Student() { Mark=7 });

            int initial = 1;
            //Print the stack
            foreach (Student item in student)
            {
                item.Rank = initial;
                Console.WriteLine(item.Mark + " , " + item.Rank);
                initial++;
            }

            //Delete an element from the stack LIFO access
            Student element = student.Pop();
            Console.WriteLine("Pop() used -> "+ element.Mark + " , " + element.Rank);

            //Display the last element without deleting
            Student element1 = student.Peek();
            Console.WriteLine("Peek() used ->  " + element1.Mark + " , " + element1.Rank);

            Console.ReadKey();

        }
    }
}
