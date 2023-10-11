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

    for (int i = 1; i <= 10; i++)
    {
      lock (Shared.LockObject)
      {
        Console.WriteLine("Producer: Generating data");
        Thread.Sleep(7000); //7 sec

        if (Shared.Buffer.Count == Shared.BufferCapacity)
        {
          //Buffer is full
          Console.WriteLine("Buffer is full. Waiting for signal from consumer.");
          Monitor.Wait(Shared.LockObject); //Wait for signal from consumer thread
        }

        Shared.Buffer.Enqueue(i);

        Console.WriteLine($"Producer produced: {i}");
        Shared.Print();

        Monitor.Pulse(Shared.LockObject); //Wake-up consumer thread
      }
    }

    Console.WriteLine($"Production Completed");
  }
}


class Consumer
{
  public void Consume()
  {
    Console.WriteLine($"Consumer Started");

    for (int i = 0; i < 10 ; i++)
    {
      lock (Shared.LockObject)
      {
        if (Shared.Buffer.Count == 0)
        {
          Console.WriteLine("Buffer is empty. Waiting for signal from producer");
          Monitor.Wait(Shared.LockObject);
        }
      }

      Console.WriteLine("Consumer: Processing Data");
      Thread.Sleep(2500); //2.5 seconds delay

      lock (Shared.LockObject)
      {
        int val = Shared.Buffer.Dequeue();
        Console.WriteLine($"Consumer consumed: {val}");

        //Signal the producer that there is a space in the buffer
        Monitor.Pulse(Shared.LockObject);
      }
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