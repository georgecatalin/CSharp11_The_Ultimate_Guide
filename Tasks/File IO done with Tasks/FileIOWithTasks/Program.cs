using System.Threading.Tasks;
using System.IO;



namespace FileIOWithTasks
{
    public class FileWriter
    {
        public Task WriteToFile(string filePath, string content)
        {
            StreamWriter streamWriter = new StreamWriter(filePath);
            Task writeTask = streamWriter.WriteAsync(content);

            writeTask.Wait(); // wait for the complete execution of the task before closing the object to avoid exception

            streamWriter.Close();
            return writeTask;
        }
    }

    public class FileReader
    {
        public Task<string> ReadFromFile(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);
            Task<string> readTask = streamReader.ReadToEndAsync();

            readTask.Wait(); // wait for the complete execution of the task before closing the object to avoid exception

            streamReader.Close();
            return readTask;
        }
    }



    public class Program
    {
        private const string _filePath = "D:\\Training\\CSharp11_The_Ultimate_Guide\\Tasks\\Sandbox\\threads.txt";
        private const string  _content = "Threading can be significantly more complex to manage than tasks." +
            " You have to deal with low-level thread creation, synchronization primitives (e.g., locks, mutexes) which can lead to more error-prone code.";


        static void Main(string[] args)
        {
            Console.WriteLine("File IO using Tasks");
            Console.WriteLine("***********************************************************************************************************");


            //create objects of the two utility classes
            FileWriter fileWriter = new FileWriter();
            FileReader fileReader = new FileReader();

            Task writerTask = fileWriter.WriteToFile(_filePath, _content);

            writerTask.Wait(); // block the execution of the Main Thread until the execution of the writerTask is completed, and continue the running of the Main Thread from that point

            Console.WriteLine("The write to the file has been completed.");


            Task<string> readerTask = fileReader.ReadFromFile(_filePath);

            readerTask.Wait();
            /* up to this point the method ReadFromFile() was executed and the task object returned and hence created
             * next, with the Wait() method the execution of the Main Thread is blocked until the execution of the readerTask completes
             * */

            Console.WriteLine("The read from the file was completed");

            Console.WriteLine("The content of the file read is \t -> {0}.", readerTask.Result);

            Console.ReadKey();

        }
    }
}
