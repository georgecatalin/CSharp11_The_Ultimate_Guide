using System;
using System.Collections;



namespace ArrayListSample
{
    internal class Sample
    {
        public int GetNumber() => 1978;

        public double GetDoubleNumber() => 46.8;

        public string GetMessage() => "George";

        public Employee GetEmployee()
        {
            return new Employee() { Name = "Sorina" };
        }

    }

    internal class Employee
    {
        public string Name { get; set; }

        internal class Program
        {
            static void Main(string[] args)
            {
                ArrayList myArrayList = new ArrayList() { 2011, 1954, 13.5, "Mara", 'c' };

                Sample mySample = new Sample();

                //add element
                myArrayList.Add(mySample.GetNumber());
                myArrayList.Add(mySample.GetDoubleNumber());
                myArrayList.Add(mySample.GetMessage());
                myArrayList.Add(mySample.GetEmployee());


                //print the elements
                foreach (var item in myArrayList)
                {
                    if (item is Employee employee) //this is pattern matching
                    {
                        Console.WriteLine(employee.Name);
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
