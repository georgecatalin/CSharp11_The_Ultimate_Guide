using System;
using System.IO;
using System.Text;

namespace FileStreamClass
{
    internal class Program
    {
        static void Main()
        {
            //how to create an object of the FileStream Class
            string filePath = "D:\\Training\\CSharp11_The_Ultimate_Guide\\Using System.IO namespace\\practice_here\\myfile.txt";

            //1 by instantiating with the Filestream() class constructor
            FileStream fileStream_1 = new FileStream(filePath,FileMode.Create, FileAccess.Write);

            //2 by using static methods of the static class File()
            /*
            FileStream fileStream_2 = File.Create(filePath);
            FileStream fileStream_3 = File.Open(filePath, FileMode.Create, FileAccess.Write);
            FileStream fileStream_4 = File.OpenWrite(filePath);
            */

            //3 by using instance methods of the class FileInfo()
            FileInfo fileInfo = new FileInfo(filePath);

            /*
            FileStream fileStream_5 = fileInfo.Create();
            FileStream fileStream_6 = fileInfo.Open(FileMode.Create,FileAccess.Write);
            FileStream fileStream_7 = fileInfo.OpenWrite();
            */

            //how to write to the file
            string content_1 = "Galați - Otopeni De La 80 RON — Beneficiezi de Wi-Fi Gratuit, Prize Pentru Încărcare, Bagaj Inclus în Prețul Biletului";
            //convert to bytes array
            byte[] byteArray_1 = Encoding.ASCII.GetBytes(content_1);

            //write bytearray to file
            fileStream_1.Write(byteArray_1, 0, byteArray_1.Length);


            Console.WriteLine("Content 1 was added to file");

            string content_2 = "ransfer aeroport rapid. Rezerva acum. Rezervare bilet pe loc. Alege locul. Alege calitatea.";
            byte[] byteArray_2 = Encoding.ASCII.GetBytes(content_2);
            fileStream_1.Write(byteArray_2, 0, byteArray_2.Length);
            fileStream_1.Close();

            Console.WriteLine("Content 2 was added to file");


            //how to read from files with FileStream() class
            //it is advisable to use different filestream objects when reading and writing on the same file
            FileStream fileStream_read_1 = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            //additional possibilities to create the filestream object with the static File() class
            /*
            FileStream fileStream_read_2 = File.Open(filePath, FileMode.Open, FileAccess.Read);
            FileStream fileStream_read_3 = File.OpenRead();
            */

            //other possibilities to create a new filestream for reading purposes with FileInfo() class
            /*
            FileStream fileStream_read_4 = fileInfo.Open(FileMode.Open, FileAccess.Read);
            FileStream fileStream_read_5 = fileInfo.OpenRead();
            */

            //create  an empty byte array as the Filestream() class works only with array of bytes
            byte[] myByteArray = new byte[fileStream_read_1.Length];

            //read from the filestream object into the byte array
            fileStream_read_1.Read(myByteArray, 0,(int) fileStream_read_1.Length);

            //convert from byte array to string
            string whatToRead = Encoding.ASCII.GetString(myByteArray);

            Console.WriteLine("I read this from the file:");
            Console.WriteLine(whatToRead);


            fileStream_read_1.Close();

            Console.ReadKey();
        }
    }
}
