using System.Threading.Tasks;
using System.Diagnostics;

class UpCounter
{
  public void CountUp(int count)
  {
    Console.WriteLine("\nCount-Up starts");
    for (int i = 1; i <= count; i++) 
    {
      Console.Write($"i = {i}, ");
    }
    Console.WriteLine("\nCount-Up ends");
  }
}

class DownCounter
{
  public void CountDown(int count)
  {
    Console.WriteLine("\nCount-Down starts");
    for (int j = count; j >= 1; j--)
    {
      Console.Write($"j = {j}, ");
    }
    Console.WriteLine("\nCount-Down ends");
  }
}


class Program
{
  static void Main()
  {
    //Create an object of Stopwatch
    Stopwatch sw = new Stopwatch();

    //Tasks
    sw.Start();
    WithTasks();
    sw.Stop();
    long timeTakenForTasks = sw.ElapsedMilliseconds;
    Console.WriteLine($"\nTasks - Time Taken: {timeTakenForTasks} ms");

    //Threads
    sw.Restart();
    WithThreads();
    sw.Stop();
    long timeTakenForThreads = sw.ElapsedMilliseconds;
    Console.WriteLine($"\nThreads - Time Taken: {timeTakenForThreads} ms");


    //Comparison
    if (timeTakenForTasks < timeTakenForThreads)
    {
      Console.WriteLine("TPL is faster");
    }
    else if (timeTakenForThreads < timeTakenForTasks)
    {
      Console.WriteLine("Threading is faster");
    }
    else
    {
      Console.WriteLine("Both TPL and Threading are equal");
    }

    Console.WriteLine("Done");
    Console.ReadKey();
  }

  static void WithTasks()
  {
    //create objects for counter class
    UpCounter upCounter = new UpCounter();
    DownCounter downCounter = new DownCounter();
    CountdownEvent countdownEvent = new CountdownEvent(2);

    //create and start task
    Task task1 = Task.Run(() => {
      upCounter.CountUp(20);
      countdownEvent.Signal();
    });

    Task task2 = Task.Run(() => {
      downCounter.CountDown(20);
      countdownEvent.Signal();
    });

    countdownEvent.Wait();
  }


  static void WithThreads()
  {
    //create objects for counter class
    UpCounter upCounter = new UpCounter();
    DownCounter downCounter = new DownCounter();
    CountdownEvent countdownEvent = new CountdownEvent(2);

    //create and start task
    Thread thread1 = new Thread(() => {
      upCounter.CountUp(20);
      countdownEvent.Signal();
    });

    Thread thread2 = new Thread(() => {
      downCounter.CountDown(20);
      countdownEvent.Signal();
    });

    thread1.Start();
    thread2.Start();

    countdownEvent.Wait();
  }
}