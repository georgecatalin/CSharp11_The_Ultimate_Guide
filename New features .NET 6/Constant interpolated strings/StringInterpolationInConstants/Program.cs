/* From C# 10 onwards it is possible to use string interpolation in constants with text from other constants */


namespace StringInterpolationInConstants
{
    public class Example
    {
        public const string BaseURL = "http://www.example.com";
        public const string APIURL = $"{BaseURL}/Api"; // constants are replaced at compile time with their textual content whilst any other static members are replaced at runtime

    }


    internal class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine(Example.APIURL);
            Console.ReadKey();
        }
    }
}
