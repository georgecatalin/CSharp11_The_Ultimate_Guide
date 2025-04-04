namespace Remember_reference_variables
{
    internal class Program
    {

        static void DoStuffRef(ref int myVar)
        {
            myVar += 10;
        }

        static void DoStuffCopy(int myVar)
        {
            myVar = myVar + 10;
        }

        static void Main(string[] args)
        {
            int number = 1978;
            Console.WriteLine(number); //1978

            DoStuffCopy(number);
            Console.WriteLine(number); //1978

            DoStuffRef(ref number); // 1978 +10 =1988
            Console.WriteLine(number);

        }
    }
}
