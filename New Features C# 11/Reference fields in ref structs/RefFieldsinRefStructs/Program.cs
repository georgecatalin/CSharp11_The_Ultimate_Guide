namespace RefFieldsinRefStructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 2011;
            Console.WriteLine("The number is " + myNumber);

            NormalStruct normalStruct = new NormalStruct();
            normalStruct.Value = myNumber;
            Console.WriteLine("The number is " + myNumber);
            Console.WriteLine("The number accessed from the struct field is  " + normalStruct.Value);



            RefStruct refStruct = new RefStruct(ref myNumber);
            Console.WriteLine("The number is " + myNumber);
            Console.WriteLine("The number accessed from the ref field is  " + refStruct.Value);

            Console.WriteLine("set the number to 1978");

            myNumber = 1978;
            Console.WriteLine("The number is " + myNumber);
            Console.WriteLine("The number accessed from the ref field is  " + refStruct.Value);
            Console.WriteLine("The number accessed from the struct field is  " + normalStruct.Value);

        }
    }
}
