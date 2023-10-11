using System.Threading;

class Shared
{
  public static int SharedResource { get; set; } = 0;
  public static readonly object lockObject = new object();
}

class NumbersUpCounter
{
  public int Count { get; set; }

  public void CountUp(Action<long> callback)
  {
    long sum = 0;
    try
    {
      Console.WriteLine("Count Up started");
      Thread.Sleep(1000);

      //i = 1 to 100
      for (int i = 1; i <= Count; i++)
      {
        sum += i;

        Monitor.Enter(Shared.lockObject); //wait for lock gets opened
        Console.Write($"Shared Resource in Count-Up: {Shared.SharedResource}, "); //0
        Shared.SharedResource++;
        Monitor.Exit(Shared.lockObject); //close the lock

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"i = {i}, ");
        Thread.Sleep(100); //1000 milliseconds = 1 sec
      }
      Thread.Sleep(1000);
      Console.WriteLine("Count Up completed");
    }
    catch (ThreadInterruptedException)
    {
      Console.WriteLine("Count-Up Thread interrupted");
    }
    finally
    {
      //invoke callback method supplied from the Main thread
      callback(sum);
    }
  }
}


class NumbersDownCounter
{
  public int Count { get; set; }

  public void CountDown()
  {
    Console.WriteLine("Count Down started");
    Thread.Sleep(1000);

    //j = count to 1
    for (int? j = Count; j >= 1; j--)
    {
      Monitor.Enter(Shared.lockObject); //Wait for the lock gets opened (aquired)
      Console.Write($"Shared Resource in Count-Down: {Shared.SharedResource}, "); //1
      Shared.SharedResource--;
      Monitor.Exit(Shared.lockObject); //Close (release) the lock

      System.Console.ForegroundColor = ConsoleColor.Red;
      Console.Write($"j = {j}, ");
      Thread.Sleep(100); //1000 milliseconds = 1 sec
    }

    Thread.Sleep(1000);
    Console.WriteLine("Count Down completed");
  }
}


class Program
{
  static void Main()
  {
    //Get main thread
    Thread mainThread = Thread.CurrentThread;
    mainThread.Name = "Main thread";
    Console.WriteLine(mainThread.Name + " started"); //Main thread

    //Object of NumbersUpCounter
    NumbersUpCounter numbersUpCounter = new NumbersUpCounter() { Count = 100 };


    //Create first thread
    ThreadStart threadStart1 = new ThreadStart(() =>
    {
      numbersUpCounter.CountUp(sum =>
      {
        //receive value supplied from the thread method (CountUp)
        Console.WriteLine($"\nReturn value from Count-Up thread is: {sum}");
      });

    }); //Invoke thread method manually
    Thread thread1 = new Thread(threadStart1) { Name = "Count-Up Thread", Priority = ThreadPriority.Highest };




    //Invoke CountUp
    thread1.Start();
    Console.WriteLine($"{thread1.Name} ({thread1.ManagedThreadId}) is {thread1.ThreadState.ToString()}"); //Running



    //Object of NumbersDownCounter
    NumbersDownCounter numbersDownCounter = new NumbersDownCounter() { Count = 100 };

    //Create second thread
    ThreadStart threadStart2 = new ThreadStart(numbersDownCounter.CountDown);
    Thread thread2 = new Thread(threadStart2) { Name = "Count-Down Thread", Priority = ThreadPriority.BelowNormal };

    //Invoke CountUp
    thread2.Start();
    Console.WriteLine($"{thread2.Name} ({thread2.ManagedThreadId}) is {thread2.ThreadState.ToString()}"); //Running


    //Join
    thread1.Join();
    thread2.Join();

    Console.WriteLine($"\nShared Resource: {Shared.SharedResource}"); //Expected: 0
    Console.WriteLine(mainThread.Name + " completed");
    Console.ReadKey();
  }
}
