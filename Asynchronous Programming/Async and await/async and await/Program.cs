using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;



namespace FileIOWithTasks
{
    public class FileWriter
    {
        public async Task WriteToFile(string filePath, string content)
        {
            StreamWriter streamWriter = new StreamWriter(filePath);
            Task writeTask = streamWriter.WriteAsync(content); 
            await writeTask; // placed this task in a non-blocking condition. the rest of the code will not be executed until the completion of the task, meanwhile the called thread gets the possibility to execute some other task
            
            streamWriter.Close();

            //there is no need to return the task object, cause the async marked method automatically returns the task object
        }
    }

    public class FileReader
    {
        public async Task<string> ReadFromFile(string filePath) // async means non-blocking
        {
            StreamReader streamReader = new StreamReader(filePath);
            Task<string> readTask = streamReader.ReadToEndAsync();
            string content = await readTask; 
            /* wait for the completion of the task and not execute the next lines in the method until the task is completed
             * meanwhile the control is passed to the caller thread of this task, and the caller thread can execute some other task
             * after the execution of the task , set the task result into the 'content' variable
             * */

            streamReader.Close();
            return content; // return the content variable, while the compiler will return the Task<T> object

            //there is no need to return the task object, cause the async marked method automatically returns the task object
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

            Task writerTask = fileWriter.WriteToFile(_filePath, _content);

            await writerTask; // the execution of the main thread stops here until the writerTask is completed, whereas the OS can execute any other thread from the ThreadPool

            Console.WriteLine("The write to the file has been completed.");


            Task<string> readerTask = fileReader.ReadFromFile(_filePath);

            await readerTask; // the execution of the main thread stops here until the readerTask is completed, whereas the OS can execute any other thread from the ThreadPool

            Console.WriteLine("The read from the file was completed");

            Console.WriteLine("The content of the file read is \t -> {0}.", readerTask.Result);

            Console.ReadKey();

        }
    }
}
