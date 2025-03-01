using System;
using System.IO;

namespace BinaryReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\practice_here\binaryfile.txt";

            //create the BinaryReader() object
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            using(BinaryReader binaryReader = new BinaryReader(fileStream))
            {


                short int_read = binaryReader.ReadInt16();
                int age_read = binaryReader.ReadInt32();
                string job_read = binaryReader.ReadString();
                string name_read = binaryReader.ReadString();

                Console.WriteLine($"Year is {int_read}");
                Console.WriteLine($"Age is {age_read}");
                Console.WriteLine($"Job is {job_read}");
                Console.WriteLine($"Name is {name_read}");
            }

            Console.ReadKey();
        }
    }
}
