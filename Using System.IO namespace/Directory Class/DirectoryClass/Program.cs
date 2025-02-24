using System;
using System.IO;


namespace DirectoryClass
{
    internal class Program
    {
        static void Main()
        {
            string folderPath = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\Practice_directory";
            string folderPathIndia = folderPath + @"\India";
            string folderPathRomania = folderPath + @"\Romania";
            string folderPathUK = folderPath + @"\UK";


            //Create the folders
            Directory.CreateDirectory(folderPath);
            Directory.CreateDirectory(folderPathRomania);
            Directory.CreateDirectory(folderPathUK);
            Directory.CreateDirectory(folderPathIndia);

            //Create files inside the directories
            string filePath_1 = folderPathIndia + "\\file1.txt";
            string filePath_2 = folderPathIndia + "\\file2.txt";

            File.Create(filePath_1).Close();
            File.Create(filePath_2).Close();

            //list the files
            string[] files = Directory.GetFiles(folderPathIndia);
            files.ToList().ForEach(f => { Console.WriteLine(f); });

            //list the directories
            string[] directories = Directory.GetDirectories(folderPath);
            directories.ToList().ForEach(d => { Console.WriteLine(d); });


            //Delete folder
            Directory.Delete(folderPathUK);


            //Move directory
            string folderPathMove = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\Practice_directory_moved";
            Directory.Move(folderPath,folderPathMove);


            Console.ReadKey();
        }
    }
}
