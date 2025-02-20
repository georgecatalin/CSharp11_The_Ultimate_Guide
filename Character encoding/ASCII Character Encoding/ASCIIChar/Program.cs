using System;

namespace ASCIIChar
{
    internal class Program
    {
        static void Main()
        {
            char myChar = 'G';
            Console.WriteLine(myChar);

            //Convert the character into ASCII code
            byte asciicode = (byte)myChar;

            Console.WriteLine($"{myChar} converts to ASCII in {asciicode}.");


            //convert from ASCII code to char
            char myCharBack = (char) asciicode;
            Console.WriteLine($" {asciicode} converted back to char is {myCharBack}");

            byte[] byteArray = new byte[178];

            //display the ASCII characters for all 1..178 codes
            for (byte i = 0; i < 178; i++)
            {
                byteArray[i] = i;
            }

            //Display as string each element of the byte array
            string stringFromByteArray = System.Text.Encoding.ASCII.GetString( byteArray );

            Console.OutputEncoding = System.Text.Encoding.ASCII; // to display with the ASCII encoding only
            Console.WriteLine("The string obtained from the list of ASCII Codes is " + stringFromByteArray );

            //convert the string into an array of ASCII codes
            string mystring = "Ola amigo";
            byte[] arrayOfBytes = System.Text.Encoding.ASCII.GetBytes( mystring );

            foreach (byte b in arrayOfBytes)
            {
                Console.Write(b);
            }

            Console.ReadKey();

        }
    }
}
