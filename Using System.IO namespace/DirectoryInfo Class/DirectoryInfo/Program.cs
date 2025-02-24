using System;
using System.IO;


namespace DirectoryInfoExample
{
    internal class Program
    {
        static void Main()
        {
            string folderPath = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\Practice_directory";
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);

            //create a folder
            directoryInfo.Create();
            Console.WriteLine("The folder was created");

            //display the properties
            Console.WriteLine("FullName = " + directoryInfo.FullName);
            Console.WriteLine("Name = " + directoryInfo.Name);
            Console.WriteLine("Parent =" + directoryInfo.Parent);
            Console.WriteLine("Root as an object of DirectoryInfo = " + directoryInfo.Root.FullName);
            Console.WriteLine("Last Access Time = " + directoryInfo.LastAccessTime.ToString());
            Console.WriteLine("Created date and time = " + directoryInfo.CreationTime.ToString());
            Console.WriteLine("Last modified time =" + directoryInfo.LastWriteTime.ToString());

            //create subfolders
            directoryInfo.CreateSubdirectory("India");
            Console.WriteLine("created subfolder 'India'");

            directoryInfo.CreateSubdirectory("Romania");
            Console.WriteLine("created subfolder 'Romania' ");

            directoryInfo.CreateSubdirectory("USA");
            Console.WriteLine("created subfolder 'USA' ");

            //get directories
            DirectoryInfo[] directories = directoryInfo.GetDirectories();

            foreach (DirectoryInfo d in directories)
            {
                Console.WriteLine(d.FullName + " ");
            }

            //create files
            new FileInfo(directoryInfo.FullName + @"\sample_file.txt").Create().Close();
            new FileInfo(directoryInfo.FullName + @"\sample_file_1.txt").Create().Close();
            new FileInfo(directoryInfo.FullName + @"\sample_file_2.txt").Create().Close();


            //get files
            FileInfo[] fileInfoArray = directoryInfo.GetFiles();
            foreach (FileInfo fileInfo in fileInfoArray)
            {
                Console.WriteLine(fileInfo.FullName + " " + fileInfo.Length);
            }

            //move directory
            string folderPathMove = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\Practice_directory_moved";
            directoryInfo.MoveTo(folderPathMove);
            Console.WriteLine("The directory was moved to 'D:\\Training\\CSharp11_The_Ultimate_Guide\\Using System.IO namespace\\Practice_directory_moved'");

            Console.ReadKey();
        }
    }
}
