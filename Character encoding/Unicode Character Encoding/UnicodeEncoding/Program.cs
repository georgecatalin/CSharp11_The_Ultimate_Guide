using System;
using System.Security.Cryptography;

namespace UnicodeEncoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unicodeString = "\u1638";
            Console.WriteLine(unicodeString);

            string thisString = "I miss my old times";

            //convert from string encoded with unicode to array of bytes
            byte[] arrayOfBytes = System.Text.Encoding.Unicode.GetBytes(thisString);

            foreach (byte b in arrayOfBytes)
            {
                Console.WriteLine(b);
            }

           arrayOfBytes.ToList().ForEach(item => Console.WriteLine(item));  

            // convert from array of bytes to string
            string back = System.Text.Encoding.Unicode.GetString(arrayOfBytes);
            Console.WriteLine(back);

            Console.ReadKey();

        }
    }
}
