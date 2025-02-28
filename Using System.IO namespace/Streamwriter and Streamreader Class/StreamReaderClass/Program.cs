using System;
using System.IO;


namespace StreamReaderClass
{
    internal class Program
    {
        static void Main()
        {
            //there are three ways of creating an object of the StreamReader() class
            StreamReader streamReader;

            string filePath = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\practice_here\myfile.txt";
            string filePath2 = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\practice_here\readme.txt";
            //option 1
            /*
            streamReader = new StreamReader(filePath);
            */

            //option 2
            /*
            FileInfo fileInfo = new FileInfo(filePath);
            streamReader = fileInfo.OpenText();
            */

            //option 2
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            using (streamReader = new StreamReader(fs))
            {
                string all_content = streamReader.ReadToEnd();
                Console.WriteLine(all_content);
            }


            Console.WriteLine("\n\nThis is the content of the file read all at once");


            using (StreamReader sr1  = new StreamReader(filePath))
            {

                int char_read;

                do
                {
                    char[] char_array = new char[50];
                    char_read = sr1.Read(char_array, 0, char_array.Length);

                    string what_has_been_read = new string(char_array);
                    Console.WriteLine(what_has_been_read);
                }while (char_read > 0);

            }



            Console.ReadKey();
        }
    }
}
