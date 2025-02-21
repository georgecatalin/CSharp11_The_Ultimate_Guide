using System;
using System.IO;


namespace FileClass
{
    internal class Program
    {
        static void Main()
        {
            //create a file, this recreates a new file in case it already exists
            string filePath1 = "D:\\Training\\CSharp11_The_Ultimate_Guide\\Using System.IO namespace\\Practice_directory\\New_file.txt"; // or \\ can be escaped with @ in front of "
            string filePath1_escape_char = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\Practice_directory\New_file.txt";

            string filePath1_copy = "D:\\Training\\CSharp11_The_Ultimate_Guide\\Using System.IO namespace\\Practice_directory\\New_file_copy.txt";
            string filePath1_move = "D:\\Training\\CSharp11_The_Ultimate_Guide\\Using System.IO namespace\\Practice_directory\\New_file_move.txt";

            File.Create(filePath1).Close();
            Console.WriteLine($"{filePath1} was created.");

            //check if the file was created properly
            bool isCreate = File.Exists(filePath1);

            if (isCreate)
            {
                Console.WriteLine($"\nFile {filePath1} was  found.");

                //Copy the file to another file
                File.Copy(filePath1 , filePath1_copy);
                Console.WriteLine($"{filePath1} was copied to {filePath1_copy}");

                //Move the file to another file -> File.Move() can be used for renaming the file or moving the file on a location on the same drive letter only
                File.Move(filePath1 , filePath1_move);
                Console.WriteLine($"{filePath1_copy} was moved to {filePath1_move}");

                //Delete the file
                File.Delete(filePath1_move);
                Console.WriteLine($"{filePath1_move} was deleted.");
            }
            else
            {
                Console.WriteLine($"\nFile {filePath1} was not found");
            }
        }
    }
}
