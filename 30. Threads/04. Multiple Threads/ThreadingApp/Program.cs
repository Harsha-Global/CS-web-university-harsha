using System.Threading;

class NumbersCounter
{
  public void CountUp()
  {
    //i = 1 to 100
    for (int i = 1; i <= 100; i++) 
    {
      System.Console.ForegroundColor = ConsoleColor.Green;
      Console.Write($"i = {i}, ");
    }
  }

  public void CountDown()
  {
    //j = 100 to 1
    for (int j = 100; j >= 1; j--)
    {
      System.Console.ForegroundColor = ConsoleColor.Red;
      Console.Write($"j = {j}, ");
    }
  }
}

class Program
{
  static void Main()
  {
    //Get main thread
    Thread mainThread = Thread.CurrentThread;
    mainThread.Name = "Main thread";
    Console.WriteLine(mainThread.Name); //Main thread

    //Object of NumbersCounter
    NumbersCounter numbersCounter = new NumbersCounter();

    //Create first thread
    ThreadStart threadStart1 = new ThreadStart(numbersCounter.CountUp);
    Thread thread1 = new Thread(threadStart1);
    thread1.Name = "Count-Up Thread";
    Console.WriteLine($"{thread1.Name} is {thread1.ThreadState.ToString()}"); //Unstarted

    //Invoke CountUp
    thread1.Start();
    Console.WriteLine($"{thread1.Name} is {thread1.ThreadState.ToString()}"); //Running



    //Create second thread
    ThreadStart threadStart2 = new ThreadStart(numbersCounter.CountDown);
    Thread thread2 = new Thread(threadStart2);
    thread2.Name = "Count-Up Thread";
    Console.WriteLine($"{thread2.Name} is {thread2.ThreadState.ToString()}"); //Unstarted

    //Invoke CountUp
    thread2.Start();
    Console.WriteLine($"{thread2.Name} is {thread2.ThreadState.ToString()}"); //Running



    Console.WriteLine(mainThread.Name + " completed");
    Console.ReadKey();
  }
}
