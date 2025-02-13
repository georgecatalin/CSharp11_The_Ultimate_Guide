namespace AnonymousArrays
{
    internal class Program
    {
        /// <summary>
        /// Explaining anonymous arrays (implicitly typed arrays)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var anonymousArray = new[]
            {
                new {Name = "George", Email = "george.calin@email.com"},
                new {Name = "Mara", Email = "mara@email.com"},
                new {Name = "Sorina", Email = "sorina@email,com"}
            };

            foreach (var anonymous in anonymousArray)
            {
                Console.WriteLine(anonymous.Name + " " + anonymous.Email);
            }

            Console.ReadKey();
        }
    }
}
