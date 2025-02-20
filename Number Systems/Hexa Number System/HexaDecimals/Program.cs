namespace HexaDecimals
{
    internal class Program
    {
        static void Main()
        {
            int decimalNumber = 100;
            // convert a decimal number to hexa
            string hexadecimal = Convert.ToString(decimalNumber,16);
            Console.WriteLine($"{decimalNumber} -> {hexadecimal}");

            // convert back to decimal from hexa
            int decimalNumberAgain = Convert.ToInt32(hexadecimal,16);
            Console.WriteLine($"{hexadecimal} -> {decimalNumberAgain}");

            // representing hexadecimals as string literals
            int number = 0x25;
            number++;
            Console.WriteLine(number);
            
            Console.ReadKey();
        }
    }
}
