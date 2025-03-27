/* The range struct has appeared in the later versions of C#  like C# 8 and allow selection of several elements of a collection like an array in a simpler way
 * without the use of LINQ
 * */


using System.Security.Cryptography;

namespace WorkingWithTheRangeStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myFriends = new string[] { "Sorin", "Alex", "Pavel", "Cornel", "Liviu" };


            //how to select a consecutive interval the old way with LINQ
            IEnumerable<string> mySelectedFriends = myFriends.Skip(1).Take(3); // { "Alex", "Pavel", "Cornel" }
            Console.WriteLine("how to select a consecutive interval the old way with LINQ");
            mySelectedFriends.ToList().ForEach(x => Console.WriteLine(x));


            //how to select a consecutive interval using the Range struct
            Range myRange = new Range(1, 4); // { "Alex", "Pavel", "Cornel" }
            IEnumerable<string> mySelectedFriendsNewWay = myFriends[myRange];
            Console.WriteLine("\nhow to select a consecutive interval using the Range struct");
            foreach (string s in mySelectedFriendsNewWay)
                { Console.WriteLine(s); }

            //how to select a consecutive interval using the Range struct EXPLICITLY
            IEnumerable<string> mySelectedFriendsNewWay1 = myFriends[1..4]; // { "Alex", "Pavel", "Cornel" }
            Console.WriteLine("\nhow to select a consecutive interval using the Range struct EXPLICITLY");
            foreach (string s in mySelectedFriendsNewWay)
            { Console.WriteLine(s); }

            Console.ReadKey();

        }
    }
}
