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
    //create objects for counter class
    UpCounter upCounter = new UpCounter();
    DownCounter downCounter = new DownCounter();

    //create and start task
    Task task1 = Task.Factory.StartNew(() => {
      upCounter.CountUp(20);
    });

    Task task2 = Task.Factory.StartNew(() => {
      downCounter.CountDown(20);
    });

    //task1.Wait();
    //task2.Wait();
    Task.WaitAll(task1, task2);
    Console.ReadKey();
  }
}

