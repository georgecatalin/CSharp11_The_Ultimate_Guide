using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;



namespace FileIOWithTasks
{
    public class FileWriter
    {
        public async Task WriteToFile(string filePath, string content)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                await streamWriter.WriteAsync(content);
            } //automatically dispose the streamWriter object at the end
        }
    }

    public class FileReader
    {
        public async Task<string> ReadFromFile(string filePath) // async means non-blocking
        {
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string content = await streamReader.ReadToEndAsync();
                return content;
            }
        }
    }



    public class Program
    {
        private const string _filePath = "D:\\Training\\CSharp11_The_Ultimate_Guide\\Tasks\\Sandbox\\threads.txt";
        private const string  _content = "Threading can be significantly more complex to manage than tasks." +
            " You have to deal with low-level thread creation, synchronization primitives (e.g., locks, mutexes) which can lead to more error-prone code.";


        static async Task Main(string[] args)
        {
            Console.WriteLine("File IO using Tasks");
            Console.WriteLine("***********************************************************************************************************");


            //create objects of the two utility classes
            FileWriter fileWriter = new FileWriter();
            FileReader fileReader = new FileReader();

            await fileWriter.WriteToFile(_filePath, _content);

            Console.WriteLine("The write to the file has been completed.");


            string thisResult = await  fileReader.ReadFromFile(_filePath);

            Console.WriteLine("The read from the file was completed");

            Console.WriteLine("The content of the file read is \t -> {0}.", thisResult);

            Console.ReadKey();

        }
    }
}
