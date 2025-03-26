namespace ReturnTypeLambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var SayHello =  () => "Hello from Lambda Expression return type";

            // Scenario 1 when we need to specify the return type of the lambda expression is when we wish to return two kinds of types from a lambda expression
            Func<int, object> GetMark = object (int mark) =>
            {
                if (mark >= 35)
                {
                    return "Passed the assessment";
                }
                else
                {
                    return 0;
                }
            };

            Console.WriteLine(SayHello());
            Console.WriteLine(GetMark(60));
            Console.WriteLine(GetMark(20));


            // Scenario 2 when we need to specify the return type of lambda expressions we need to specify the type of the output, so that we need not to typecast again
            var GetMarks = IList<int> () => new int[] { 18, 30, 46, 46 };
            IList<int> result = GetMarks();

            foreach (int mark in result)
            {
                Console.WriteLine(mark);
            }
        }
    }
}