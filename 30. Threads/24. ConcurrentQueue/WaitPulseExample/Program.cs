using System.Collections.Concurrent;
using System.Threading;

static class Shared
{
  public static ConcurrentQueue<int> Buffer = new ConcurrentQueue<int>(); //Buffer to store int data values
  public const int BufferCapacity = 5; //maximum capacity of the buffer (queue)
  public static ManualResetEvent ProducerEvent = new ManualResetEvent(true);
  public static ManualResetEvent ConsumerEvent = new ManualResetEvent(false);

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
    Console.WriteLine("Producer: Generating data");
    Thread.Sleep(7000); //7 sec

    for (int i = 1; i <= 10; i++)
    {
      if (Shared.Buffer.Count == Shared.BufferCapacity)
      {
        //Buffer is full
        Console.WriteLine("Buffer is full. Waiting for signal from consumer.");
        Shared.ProducerEvent.Reset(); //Sets the state of producer event to "unsignaled".
      }

      Shared.ProducerEvent.WaitOne();


      Shared.Buffer.Enqueue(i);

      Console.WriteLine($"Producer produced: {i}");
      Shared.Print();

      Shared.ConsumerEvent.Set(); //Sets the consumer event state as "signaled". It wakes-up the consumer thread
    }


    Console.WriteLine($"Production Completed");
  }
}


class Consumer
{
  public void Consume()
  {
    Console.WriteLine($"Consumer Started");

    for (int i = 0; i < 10; i++)
    {
      if (Shared.Buffer.Count == 0)
      {
        Console.WriteLine("Buffer is empty. Waiting for signal from producer");
        Shared.ConsumerEvent.Reset(); //Set the consumer event as "unsignaled"
      }

      Shared.ConsumerEvent.WaitOne();

      Console.WriteLine("Consumer: Processing Data");
      Thread.Sleep(2500); //2.5 seconds delay

      bool isSuccess = Shared.Buffer.TryDequeue(out int val);
      if (isSuccess)
      {
        Console.WriteLine($"Consumer consumed: {val}");
      }
      else
      {
        Console.WriteLine("Failed to read data from queue");
      }

      //Signal the producer that there is a space in the buffer
      Shared.ProducerEvent.Set();
    }


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
    Thread producerThread = new Thread(producer.Produce) { Name = "Producer Thread" };
    Thread consumerThread = new Thread(consumer.Consume) { Name = "Consumer Thread" };

    //Start threads
    producerThread.Start();
    consumerThread.Start();

    //Join
    producerThread.Join();
    consumerThread.Join();

    Console.ReadKey();
  }
}