using System;
using System.IO;


namespace StreamWriterClass
{
    internal class Program
    {
        static void Main()
        {
            // StreamWriter() class can be used for writing to text without the need of converting the string to byte arrays.But can only be used with text files, no binary files


            string filePath = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\practice_here\readme.txt";
            string filePath2 = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\practice_here\readme2.txt";
            StreamWriter streamWriter;

            //there exist multiple ways to create a streamwriter object
            /*
            streamWriter = new StreamWriter(filePath);
            */

            //the object can be created with the constructor using the Filestream
            /*
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            streamWriter = new StreamWriter(fileStream);
            */

            //the object can be created using methods of FileInfo() class
            FileInfo fileInfo = new FileInfo(filePath);
            streamWriter = fileInfo.CreateText(); // OR fileInfo.AppendText()

            streamWriter.WriteLine("This is the first line.");
            streamWriter.WriteLine("This is the second line.");
            streamWriter.WriteLine("This is the thirs line.");

            streamWriter.Close();

            //another of closing the open resources is using

            using (streamWriter = new StreamWriter(filePath2))
            {
                streamWriter.WriteLine("This line is written in the using statement");
            }

            Console.ReadKey();
        }

    }
}
