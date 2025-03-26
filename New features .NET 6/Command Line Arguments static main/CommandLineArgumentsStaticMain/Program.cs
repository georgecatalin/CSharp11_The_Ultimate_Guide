namespace CommandLineArgumentsStaticMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There are {0} arguments", args.Length);

            int sum = 0;
            if(args.Length > 0)
            {
                foreach (string arg in args)
                {
                    if(int.TryParse(arg, out int result))
                    {
                        sum += result;
                    }

                }
            }

            Console.WriteLine("The sum of the arguments is {0}.", sum);
            Console.ReadKey();

        }
    }
}
