public class Program
{
    static void Main()
    {
        int number = 2;
        string result;

        result = number switch
        {
            1 => "Employee", // Read like this : in case of number is 1 then set result to "Employee"
            2 => "Customer", // in case that number is 2 then set result to "Customer"
            3 => "Supplier", // ....
            _ => "No role available"
        };

        Console.WriteLine(result);

        Console.ReadKey();
    }
}
