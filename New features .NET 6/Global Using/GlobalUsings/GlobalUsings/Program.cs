// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> list = new List<int>() { 1978, 1955, 2011, 1954, 1977 };
List<int> selectionList = list.Where(number => number >= 1978).ToList();

selectionList.ForEach(number =>  Console.WriteLine(number));

Console.ReadKey();