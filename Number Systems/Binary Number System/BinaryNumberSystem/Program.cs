namespace BinaryNumberSystem
{
    internal class Program
    {
        static void Main()
        {
            int decimalNumber = 13;
            //converting from decimal to binary
            string binaryNumber = Convert.ToString(decimalNumber, 2);

            Console.WriteLine($"The binary number obtained after the conversion of {decimalNumber} is {binaryNumber}." );

            //converting back from binary to decimal
            int decimalNumberAgain = Convert.ToInt32(binaryNumber, 2);
            Console.WriteLine($"The decimal number obtained after the conversion of {binaryNumber} is {decimalNumberAgain}");

            //how to represent binary string literals
            int number = 0b1101;
            number++;
            Console.WriteLine("The number is -> " + number);

            Console.ReadKey();

        }
    }
}
