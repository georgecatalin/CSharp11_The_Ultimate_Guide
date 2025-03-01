using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerialization
{
    internal class Program
    {
        static void Main()
        {
            //create object to be serialized - the simple case
            Country country = new Country() { Id = 125, Name = "Romania" };

            //create XMLSerializer() class instance
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Country));
            string filePathCountry = @"D:\Workshop\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\practice_here\country.xml";
            string filePathContinents = @"D:\Workshop\Training\CSharp11_The_Ultimate_Guide\Using System.IO namespace\practice_here\continents.xml";
            FileStream fileStream = new FileStream(filePathCountry, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fileStream, country);
            fileStream.Close();
            Console.WriteLine($"country.xml was created");

            //serialize - a more complex case
            List<Continent> continentList = new List<Continent>()
            {
                new Continent()
                {
                    Name = "Europe",
                    Countries = new List<Country>()
                    {
                       new Country() { Id=1, Name="Germany"},
                       new Country() { Id=2, Name="France"},
                       new Country() { Id=3, Name="UK"}
                    }
                },
                new Continent()
                {
                    Name = "Asia",
                    Countries = new List<Country>()
                    {
                       new Country() { Id=1, Name="China"},
                       new Country() { Id=2, Name="Japan"},
                       new Country() { Id=3, Name="South Korea"}
                    }
                },
                new Continent()
                {
                    Name = "North America",
                    Countries = new List<Country>()
                    {
                       new Country() { Id=1, Name="Mexico"},
                       new Country() { Id=2, Name="United States"},
                       new Country() { Id=3, Name="Canada"}
                    }
                },
            };

            FileStream fileStream1 = new FileStream(filePathContinents, FileMode.Create, FileAccess.Write);
            XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(List<Continent>));

            xmlSerializer1.Serialize(fileStream1, continentList);
            Console.WriteLine($"continents.xml was created");
            fileStream1.Close();

            //Deserialization below
            FileStream fileStream2 = new FileStream(filePathContinents, FileMode.Open, FileAccess.Read);
            List<Continent>? listContinent = xmlSerializer1.Deserialize(fileStream2) as List<Continent>;
           


            foreach(Continent continent in  listContinent)
            {
                Console.WriteLine(continent.Name);
                foreach(Country country1 in continent.Countries)
                { Console.WriteLine("\t{1} - {0}", country1.Name, country1.Id); }
            };
     
       
            Console.ReadKey();
        }
    }
}