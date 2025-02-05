using System;

namespace ForEachToArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myFriends = new List<string>() { "Sorin", "Alex", "Liviu", "Marius", "Cornel" };


            Console.WriteLine();
            Console.WriteLine("display the list");


            myFriends.ForEach(friend => { Console.WriteLine(friend); });


            string[] myFriendsArray = myFriends.ToArray();

            Console.WriteLine();
            Console.WriteLine("display the array");

            foreach (var friend in myFriendsArray) Console.WriteLine(friend); 

            Console.ReadKey();
        }
    }
}
