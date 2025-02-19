using System;
using DateTimeLib;


namespace DateTime_Introduction
{
    internal class Program
    {
        static void Main()
        {
            Person person = new Person();

            person.Name = "Mara Calin";
            person.DateOfBirth = DateTime.Parse("1978-10-21 19:23:55.654"); // introducing the DateTime class type
            person.DateOfGraduation = Convert.ToDateTime("2001-07-01 13:45:12.456");

            Console.WriteLine(person.Name);
            Console.WriteLine(person.DateOfBirth.ToString()); //the display of the DateTime property depends upon the settings in the Windows OS of the user


            //properties of the DateTime objects
            Console.WriteLine("Year of birth " + person.DateOfBirth.Year);
            Console.WriteLine("Month of birth " + person.DateOfBirth.Month);
            Console.WriteLine("Day of birth " + person.DateOfBirth.Day);
            Console.WriteLine("Hour of birth " + person.DateOfBirth.Hour);
            Console.WriteLine("Minutes of birth " + person.DateOfBirth.Minute);
            Console.WriteLine("Seconds of birth " + person.DateOfBirth.Second);
            Console.WriteLine("Milliseconds of birth " + person.DateOfBirth.Millisecond);
            Console.WriteLine("Day of the Week  of birth " + person.DateOfBirth.DayOfWeek);
            Console.WriteLine("Day of the Week as int  of birth " + (int) person.DateOfBirth.DayOfWeek);
            Console.WriteLine("Day of the Year of birth " + person.DateOfBirth.DayOfYear);

            DateTime now = DateTime.Now;
            Console.WriteLine("The date now is " + now.ToString());

            Console.ReadKey();
        }
    }
}
