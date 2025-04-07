using InnerClass;
using System;

namespace thisProgram
{
    public class Program
    {
        static void Main()
        {
            InnerClass.OuterClass oc = new InnerClass.OuterClass();
            InnerClass.Student s = new InnerClass.Student() { MaxMarks = 10, SecuredMarks = 20 };

            Console.WriteLine(oc.CalculatePercentage(s));


            OuterClass.InnerClass innerClass = new OuterClass.InnerClass();
            Console.WriteLine(innerClass.Multiply(10, 2000));

        }
    }
}
