string filePath = "D:\\Training\\CSharp11_The_Ultimate_Guide\\New features .NET 6\\Sandbox\\readme.txt";

Console.WriteLine($"There are {args.Length} arguments read from the keyboard in terminal window");

if(args.Length == 1)
{
    if(File.Exists(filePath))
    {
        string contentOfFile = File.ReadAllText(filePath);
        Console.WriteLine(contentOfFile);
    }
    else
    {
        Console.WriteLine("The file does not exist at the path you provided as argument");
    }
}
else
{
    Console.WriteLine("You must provide an adequate number of arguments");
}

Console.ReadKey();