using System;
using System.Collections.Generic;
using System.IO;


namespace FileClassReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\Practice_directory\car_brands.txt";
            string content = "There are multiple car brands in Europe.";

            string filePath1 = @"D:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\Practice_directory\car_brands.txt";

            //write content to file -> it recreates existing file , if any, at all times when appealed
            File.WriteAllText(filePath, content);
            Console.WriteLine($"\n{filePath} \t was created the the following content \t {content} was added to it.");

            //read content from the file
            string readContent = File.ReadAllText(filePath);
            Console.WriteLine($"\nI read the following content {readContent} from the file {filePath}");

            //read from List collection and write to file
            List<string> cars = new List<string>() { "Dacia", "Ford", "Audi" };
            File.WriteAllLines(filePath1, cars);
            Console.WriteLine("Lines added to file");

            //read from file into List of strings
            string[] myArray =File.ReadAllLines(filePath1);

            myArray.ToList().ForEach(x => Console.WriteLine(x));    

            Console.ReadKey();
        }
    }
}
