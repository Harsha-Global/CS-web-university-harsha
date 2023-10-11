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

    //Invoke CountUp
    numbersCounter.CountUp();

    //Invoke CountDown
    numbersCounter.CountDown();

    Console.WriteLine(mainThread.Name + " completed");
    Console.ReadKey();
  }
}
