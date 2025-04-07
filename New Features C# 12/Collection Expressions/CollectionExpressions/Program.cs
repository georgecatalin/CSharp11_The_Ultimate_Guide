/* Notes
 * Collection expressions appeared in C# 12 and they can be used for now with the collections that support collection initializers
 * 1. lists<t>
 * 2. arrays
 * 3. interface IList<T>
 * 4. interface ICollection<T>
 * ** */

using System.Linq.Expressions;

namespace CollectionExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //old fashion of initializing lists
            List<string> autoOld = new List<string>() { "Dacia", "Renault", "Audi" };

            //new fashion of initializing lists with collection expressions
            List<string> autoNew = ["Mercedes", "BMW", "Skoda"];

            //old fashion of initializing an array

            int[] yearsOldFashion_type_1 = new int[] { 1978, 1977, 1954, 1953, 2011 };
            int[] yearsOldFashion_type_2 = { 1978, 1977, 1954, 1953, 2011 };

            //new fashion of initializing the array with list expressions
            int[] yearsNewFashion = [1978, 1977, 1954, 1953, 2011];

            IList<int> numbersNewFashion = [1, 2, 3, 4, 5];
            ICollection<decimal> grades = [5.6m, 8.9m, 9.3m, 8.5m];

            //old fashion of initializing a dictionary
            Dictionary<string, decimal> cars = new Dictionary<string, decimal>()
            {
                {"Dacia", 167.5m },
                {"Renault", 180.5m },
                {"BMW", 211.4m },
                {"Mercedes", 250.2m }
            };

            //new fashion of initializing a dictionary after C# 6.0
            Dictionary<string, decimal> carsNew = new Dictionary<string, decimal>()
            {
                ["Skoda"] = 145.6m,
                ["Nissan"] = 179.9m,
                ["Honda"] = 176.5m,
                ["Opel"] = 188.2m
            };

            foreach (var item in carsNew)
            {
                Console.WriteLine("Brand {0} and speed {1}.",item.Key, item.Value.ToString());
            }

        }
    }
}
