/* The module initializers are concepts introduced in C# 10 which allow the execution of a certain logic at the moment when the application
 * loads in the memory, just before the execution of the main() method.
 * 
 * The usage of module initializers is for : setting environment variable, database servers and/or connection strings, Azure connection strings, URLs of the APIs, file paths
 * */

public  class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello from Main()");

        // The module initializers are executed in order, if there are more of them, alphabetically
    }
}