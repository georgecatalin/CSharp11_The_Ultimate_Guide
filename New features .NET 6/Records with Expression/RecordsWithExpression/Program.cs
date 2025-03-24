namespace ConsoleApp1
{
    public record Person(string Name)
    {
        public int Age { get; set; }
        public Address? personAddress { get; set; }
    }
    public record Address()
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("George");
            person1.Age = 46;
            person1.personAddress = new Address();

            person1.personAddress.City = "Galati";
            person1.personAddress.Country = "Romania";
            Console.WriteLine($"person1 -> {person1.Name} - {person1.Age} - {person1.personAddress.City} - {person1.personAddress.Country}"); // George - 46- Galati - Romania


            Person person2 = person1; // this is reference copy as is the regular with classes. both person2 and person1 point to the same object on the heap, hence changing any of its fields gets visible in the other object
            person1.Age = 47;
            Console.WriteLine($"\nperson1 -> {person1.Name} - {person1.Age} - {person1.personAddress.City} - {person1.personAddress.Country}"); // George - 47- Galati - Romania
            Console.WriteLine($"person2 ->{person2.Name} - {person2.Age} - {person2.personAddress.City} - {person2.personAddress.Country}"); // George - 47 - Galati - Romania

            Person person3 = person1 with { }; // this is shallow copy that means a new object person3 is created, with the fields copied from the person1 object. value types fields have the same values, whilst the reference types objects point to the same object as the ones from person1 object
            person1.personAddress.City = "Braila";
            person1.personAddress.Country = "Germany";
            Console.WriteLine($"\nperson3-> {person3.Name} - {person3.Age} - {person3.personAddress.City} - {person3.personAddress.Country}");// George - 47 - Braila  - Germany
            Console.WriteLine($"person1 -> {person1.Name} - {person1.Age} - {person1.personAddress.City} - {person1.personAddress.Country}"); // George - 47- Braila - Germany
            //in C# there is no special operator that can do deep copy, that is copy completely into a new object, and even the reference type fields to point to different objects

            Person person4 = person1 with { Name = "Mara", Age = 13 }; // this is shallow copy , but also reinitializing the field
            Console.WriteLine($"\nperson4 -> {person4.Name} - {person4.Age} - {person4.personAddress.City} - {person4.personAddress.Country}"); //Mara - 13 - Braila - Germany

            Console.ReadKey();
        }
    }
}
