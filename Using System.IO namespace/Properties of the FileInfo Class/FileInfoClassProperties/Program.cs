using System;
using System.Globalization;
using System.IO;


namespace FileInfoClassProperties
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\Practice_directory\new_fileinfo.txt";

            FileInfo fileinfo = new FileInfo(filePath);
            Console.WriteLine("Exists: " + fileinfo.Exists);

            if (fileinfo.Exists)
            {
                Console.WriteLine("\nComplete filepath :" + fileinfo.FullName);
                Console.WriteLine("\nName of the file only : " + fileinfo.Name);
                Console.WriteLine("\nDirectory name  only : " + fileinfo.DirectoryName);
                Console.WriteLine("\nSize of the file: " + fileinfo.Length + " bytes ");
                Console.WriteLine("\nExtension of the file: " + fileinfo.Extension);

                Console.WriteLine("\nCreation Time: " +fileinfo.CreationTime.ToString("yyyy-MM-dd"));
                Console.WriteLine("\nLast modified Time: " + fileinfo.LastWriteTime.ToString());
                Console.WriteLine("\nLast Accessed Time: " + fileinfo.LastAccessTime.ToString());

            }

            Console.ReadKey();
        }
    }
}
