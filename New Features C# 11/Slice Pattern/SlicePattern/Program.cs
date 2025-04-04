/* NOTES:
 * 1. the slice pattern can be used within list patterns and has been added in C# 11 (.NET 7.0*)
 * 2. the slice pattern can be used either at the beginning, in the middle or at the end of the list pattern
 * */


namespace SlicePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new List<int>() { 10, 25, 50 } is [10, < 26, 50 or 150]); // returns true

            Console.WriteLine(new List<int>() { 10, 15, 25, 50 } is [10, _, < 26, 50 or 140]); // discards the second element of the list which is '15' and verifies the conditions only for the others -> true

            //suppose that you want to discard one or more elements from checking the condition, then user .. pattern matching
            Console.WriteLine(new List<int>() { 10, 15, 30, 345, 25, 50 } is [10, .., < 26, 50 or 100]); // it starts checking from the beginning and from the end the two elements, then it does not check the rest => true
        
        
        
        }
    }
}
