using System;
using System.IO;

namespace FileInfoClass
{
    internal class Program
    {
        static void Main()
        {
            string filePath1 = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\Practice_directory\new_fileinfo.txt";
            string filePath2 = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\Practice_directory\new_fileinfo_copyto.txt";
            string filePath3 = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\Practice_directory\new_fileinfo_moveto.txt";

            FileInfo fileinfo1 = new FileInfo(filePath1);
            Console.WriteLine($"{fileinfo1.Name} was created.");

            //create a file
            fileinfo1.Create().Close();

            //CopyTo()
            FileInfo fileinfo2 = fileinfo1.CopyTo(filePath2);
            Console.WriteLine($"{fileinfo1.Name} was copied to {fileinfo2.Name}");

            //MoveTo()
            fileinfo2.MoveTo(filePath3);
            Console.WriteLine($" was moved to {fileinfo2.Name}");

            //Delete()
            fileinfo2.Delete();
            Console.WriteLine($"{fileinfo2.Name} was deleted");

            Console.ReadKey();
        }
    }
}
