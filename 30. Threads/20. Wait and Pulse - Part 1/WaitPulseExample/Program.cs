using System.Threading;

static class Shared
{
  public static object LockObject = new object(); //lock object to be used by both Producer and Consumer threads
  public static Queue<int> Buffer = new Queue<int>(); //Buffer to store int data values
  public const int BufferCapacity = 5; //maximum capacity of the buffer (queue)

  public static void Print()
  {
    //O/P: Buffer: 1, 2, 3, 4, 5
    Console.Write("Buffer: ");
    foreach (int item in Buffer)
    {
      Console.Write($"{item}, ");
    }
    Console.WriteLine();
  }
}


class Producer
{
  public void Produce()
  {
    Console.WriteLine($"Producer: Generating Data");
    ///
    Console.WriteLine($"Production Completed");
  }
}


class Consumer
{
  public void Consume()
  {
    Console.WriteLine($"Consumer Started");
    ///
    Console.WriteLine($"Consumption Completed");
  }
}

class Program
{
  static void Main()
  {
    //create objects of Producer and Consumer types
    Producer producer = new Producer();
    Consumer consumer = new Consumer();

    //Create objects of Thread class
    Thread producerThread = new Thread(producer.Produce) {  Name = "Producer Thread" };
    Thread consumerThread = new Thread(consumer.Consume) {  Name = "Consumer Thread" };

    //Start threads
    producerThread.Start();
    consumerThread.Start();

    //Join
    producerThread.Join();
    consumerThread.Join();

    Console.ReadKey();
  }
}