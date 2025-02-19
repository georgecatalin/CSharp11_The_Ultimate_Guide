using System;
using System.Globalization;

namespace DateTime_Formatting
{
    internal class Program
    {
        static void Main()
        {
            DateTime dateOfBirth = DateTime.Parse("1978-10-21 21:34:56.678");

            Console.WriteLine(dateOfBirth.ToString()); // display as per Windows settings
            Console.WriteLine(dateOfBirth.ToShortDateString()); // display as per short date in Windows settings
            Console.WriteLine(dateOfBirth.ToLongDateString()); // display as per long date in Windows settings
            Console.WriteLine(dateOfBirth.ToShortTimeString()); // display as short time in Windows settings HH:mm
            Console.WriteLine(dateOfBirth.ToLongTimeString()); // display as long time in Windows settings HH:mm:ss

            Console.WriteLine(dateOfBirth.ToString("dd-MM-yy HH:mm")); //display in a customized format

            DateTime dateOfGraduation = DateTime.ParseExact("09/11/2011 19:34:10", "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);
            Console.WriteLine(dateOfGraduation.ToString());

            int noDaysInMarch2001 = DateTime.DaysInMonth(2001, 03);
            Console.WriteLine(noDaysInMarch2001);

            //how to initialize a datetime object using its constructor
            DateTime dateOfEmployment = new DateTime(2008, 01, 08, 08, 00, 01);
            Console.WriteLine("how to initialize a datetime object using its constructor");
            Console.WriteLine(dateOfEmployment.ToString());

            

            Console.ReadKey();
        }
    }
}
