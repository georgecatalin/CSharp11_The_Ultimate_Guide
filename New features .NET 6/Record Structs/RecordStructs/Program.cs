namespace RecordStructs
{
    public readonly record struct Person1(string? Name, int? Age); // internally it is compiled as struct, but the properties have get, init hence are immutable
    public record struct Person2(string? Name, int? Age);// internally it is compiled as struct, but the properties have get, set (read, write) are no longer immutable

    //ToString(), Deconstruct(), Equal() methods are available to both readonly record structs and record structs

    internal class Program
    {
        static void Main(string[] args)
        {
            Person1 person1 = new Person1("Mara", 14); // this is not an object, but a manner to appeal to the constructor of the Struct
            //structs are value types, so when copied , duplicated are created . Independent duplicates
            Console.WriteLine(person1);
            Person1 person2 = person1;
            //person1.Age = 40; not possible cause properties are immutable unchangeable due to readonly record struct
            Console.WriteLine(person1);
            Console.WriteLine(person2);


            Person2 person3 = new Person2("George", 46); // this is not an object, but a manner to appeal to the constructor of the Struct
            //structs are value types, so when copied , duplicated are created . Independent duplicates
            Console.WriteLine(person3);
            Person2 person4 = person3;
            person3.Age = 40; // it is possible to get, set the properties because Person2 is record struct and not readonly record struct
            Console.WriteLine(person1);
            Console.WriteLine(person2);

            Console.ReadKey();
        }
    }
}
