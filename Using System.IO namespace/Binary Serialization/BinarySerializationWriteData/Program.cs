using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializationWriteData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create the object whose state we wish to serialize
            Country thisCountry = new Country() { countryId = 125, countryName = "Romania", countryRegion = "Eastern Europe" };

            //serialize the object state into binary format and save to file
            string filePath = @"E:\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\practice_here\binaryserialization.txt";

            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            binaryFormatter.Serialize(fileStream, thisCountry);

            fileStream.Close();

            Console.WriteLine("Object state was serialized to file.");

            //deserialize the object state from text file
            FileStream fileStream1 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            Country object_read_from_file = (Country) binaryFormatter.Deserialize(fileStream1);

            Console.WriteLine(object_read_from_file.countryId + " " + object_read_from_file.countryName + " " + object_read_from_file.countryRegion);



            Console.ReadKey();
        }
    }
}
