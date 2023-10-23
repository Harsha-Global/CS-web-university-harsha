using System.IO;
using System.Threading.Tasks;

class FileWriter
{
  public async Task WriteFile(string fileName, string data)
  {
    using (StreamWriter writer = new StreamWriter(fileName))
    {
      await writer.WriteAsync(data);
    }
  }
}

class FileReader
{
  public async Task<string> ReadFile(string fileName)
  {
    throw new NotSupportedException();

    using (StreamReader reader = new StreamReader(fileName))
    {
      string content = await reader.ReadToEndAsync();
      return content;
    }
  }
}

class Program
{
  async static Task Main()
  {
    //Initialize
    string fileName = @"c:\CSharp\India.txt";
    FileWriter fileWriter = new FileWriter();
    FileReader fileReader = new FileReader();

    //Write data to a file asynchronously
    await fileWriter.WriteFile(fileName, "India is the most populous country by 2023"); //Block the current task (but without blocking the current thread
    Console.WriteLine("File written.");

    try
    {
      //Read data from the file asynchronously
      string content = await fileReader.ReadFile(fileName); //Block the current task (but without blocking the current thread
      Console.WriteLine("File read.");

      Console.WriteLine($"\nFile content: {content}");
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

    Console.ReadKey();
  }
}

