using System.IO;
using System.Threading.Tasks;

class FileWriter
{
  public Task WriteFile(string fileName, string data)
  {
    StreamWriter writer = new StreamWriter(fileName);
    Task writerTask = writer.WriteAsync(data);
    writer.Close();

    return writerTask;
  }
}

class FileReader
{
  public Task<string> ReadFile(string fileName)
  {
    StreamReader reader = new StreamReader(fileName);
    Task<string> readerTask = reader.ReadToEndAsync();
    reader.Close();

    return readerTask;
  }
}

class Program
{
  static void Main()
  {
    //Initialize
    string fileName = @"c:\CSharp\India.txt";
    FileWriter fileWriter = new FileWriter();
    FileReader fileReader = new FileReader();

    //Write data to a file asynchronously
    Task writerTask = fileWriter.WriteFile(fileName, "India is the most populous country by 2023");
    writerTask.Wait(); //Block until the write operation is completed
    Console.WriteLine("File written.");

    //Read data from the file asynchronously
    Task<string> readerTask = fileReader.ReadFile(fileName);
    readerTask.Wait(); //Block the current thread until the read operation is completed.
    Console.WriteLine("File read.");

    Console.WriteLine($"\nFile content: {readerTask.Result}");

    Console.ReadKey();
  }
}

