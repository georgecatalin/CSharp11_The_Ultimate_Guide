using System;
using System.IO;


namespace BinaryWriterClass
{
    internal class Program
    {
        static void Main()
        {
            short myshort = 1978;
            string name = "George Calin";
            int age = 46;
            string job = "Project Manager";

            string filePath = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\practice_here\binaryfile.txt";

            //create an object of the BinaryWriter() class using the constructor with the FileStream() object
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
            {
                binaryWriter.Write(myshort); // -> convert to binary, and afterwards write to file
                binaryWriter.Write(age); // -> convert to binary, and afterwards write to file
                binaryWriter.Write(job); // -> convert to binary, and afterwards write to file
                binaryWriter.Write(name); // -> convert to binary, and afterwards write to file

                //if not using the using statement, one would have to use specifically binaryWriter.Close(); to close the file
            }

            Console.WriteLine("The binary file was written");

            Console.ReadKey();
        }
    }
}
