/* Notes **************************************************************
 * A newer feature provided by C# 12 is the capacity to use default lambda parameters, similarly with normal methods
 * 1. each parameters with a default value has to be explicitly typed
 * 2. in lambda expressions, one can not mix implictly types with explicitly types.
 * 3. default parameters have to be at the end of the lambda expressions
 * *** */


namespace DefaultParametersInLambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the original manner of dealing with a missing parameter in lambda expressions prior to C# 12
            Func<decimal, decimal?, decimal> calculateDiscountOldWay = (amount, discount) =>
            {
                //set the discount condition in case it is missing
                decimal discountToApply = discount ?? 10m; //null coalescing operator => if the discount is null, then set it as 10m
                return amount - (amount * discountToApply / 100);
            };


            Console.WriteLine("Calculate using the old way of dealing with missing values for lambda parameters");
            Console.WriteLine(calculateDiscountOldWay(1000, null)); //900 -> Takes the discount as defaulted 10
            Console.WriteLine(calculateDiscountOldWay(1000, 20)); //800

            Console.WriteLine("\n\nCalculate using the old way of dealing with missing values for lambda parameters");
            //the new manner of dealing in C# 12
            var calculateDiscountNewWay = (decimal amount, decimal discount = 10) =>
            {
                return amount - amount * discount / 100;
            };
            Console.WriteLine(calculateDiscountNewWay(1000)); //900 -> Takes the discount as defaulted 10
            Console.WriteLine(calculateDiscountNewWay(1000, 20)); //800


            //another potential scenario of using default values in lambda expressions is when creating a logging feature in an app
            var writeLog = (string message, string error = "Nothing") =>
            {
                Console.WriteLine("{0} -> {1}", message, error);
            };

            writeLog("We are fucked");
            writeLog("We are fucked", "Shit");
        }
    }
}
