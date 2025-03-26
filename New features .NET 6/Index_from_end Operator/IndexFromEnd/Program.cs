namespace IndexFromEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1953, 1954, 1977, 1978, 2011 };

            //accessing the last element of the list in the previous versions of C# before C# 6.0
            Console.WriteLine(list[list.Count - 1]);

            //accessing the last element of the list in the later versions of C# post C# 6.0  with the index-from-end carot operator
            Console.WriteLine(list[^1]); // 2011 -> the last element has ^1
            Console.WriteLine(list[^2]); // 1978
            Console.WriteLine(list[^3]); // 1977
            Console.WriteLine(list[^4]); // 1954
            Console.WriteLine(list[^5]); // 1953

            Console.WriteLine();

            // Internally the carot index-from-end operator is using the Index struct
            Index i = ^4;
            Console.WriteLine(list[i]); // 1954


            Console.ReadKey();
        }
    }
}
