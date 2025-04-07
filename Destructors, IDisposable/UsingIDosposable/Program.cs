using ClassLibrary5;
using System;

namespace thisProgram
{
    public class Program
    {
        //this example uses the using declaration which has been added in C# 8.0
        static void DoWork()
        {
            using Sample s = new Sample();
            s.ReadDatabase();
        } // the Dispose() method gets appealed here at the end of the method



        static void Main()
        {
           using( Sample s = new Sample() )
            {
                s.ReadDatabase();
            }

            DoWork();

        }
    }
}