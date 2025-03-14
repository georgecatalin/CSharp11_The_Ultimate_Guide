using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLogger
{
    internal class ExceptionLogger
    {
        public static void AddException(Exception ex)
        {
            string filePath = @"D:\Training\CSharp11_The_Ultimate_Guide\Exception Handling\Logger\ExceptionsLog.txt";

            StreamWriter sw = File.AppendText(filePath);
            sw.WriteLine($"This error was caught on {DateTime.Now}");
            sw.WriteLine("\nException Type:");
            sw.WriteLine(ex.GetType().ToString());

            sw.WriteLine("\nException StackTrace: ");
            sw.WriteLine(ex.StackTrace);

            sw.WriteLine("\nException Message: ");
            sw.WriteLine(ex.Message);

            sw.Close();
        }
    }
}
