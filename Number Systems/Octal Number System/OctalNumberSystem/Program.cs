namespace OctalNumberSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = 25;
            // converting the decimal to octal
            string octalNumber = Convert.ToString(decimalNumber, 8);
            Console.WriteLine($"The decimal number {decimalNumber} converted to string is {octalNumber}.");

            // octal numbers can not be represented as string literals , unlike binary numbers
            int decimalNumberAgain = Convert.ToInt32( octalNumber, 8 );
            Console.WriteLine($"The octal number {octalNumber} converted to decimal number again is {decimalNumberAgain}"); 

            Console.ReadKey();
        }
    }
}
