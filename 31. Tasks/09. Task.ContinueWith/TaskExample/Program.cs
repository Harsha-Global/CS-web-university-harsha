using System.Threading.Tasks;
using System.Diagnostics;

class UpCounter
{
  public long CountUp(int count)
  {
    long sum = 0;
    Console.WriteLine("\nCount-Up starts");
    for (int i = 1; i <= count; i++)
    {
      Console.Write($"i = {i}, ");
      sum += i;
      Task.Delay(300).Wait();
    }
    Console.WriteLine("\nCount-Up ends");
    return sum;
  }
}

class DownCounter
{
  public SumData CountDown(int count)
  {
    long sum = 0;
    Console.WriteLine("\nCount-Down starts");
    for (int j = count; j >= 1; j--)
    {
      Console.Write($"j = {j}, ");
      sum += j;
      Task.Delay(300).Wait();
    }
    Console.WriteLine("\nCount-Down ends");
    return new SumData() { Sum = sum };
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
    Task<long> task1 = Task.Run(() =>
    {
      return upCounter.CountUp(20);
    });

    //Create a new continuation task object that gets executed (starts automatically) when the antedent (preceding) task is completed (either successfully or with an exception)
    Task continuationTask1 = task1.ContinueWith((antecedent) =>
    {
      Console.WriteLine($"Result from Count-Up: {task1.Result}");
    });

    Task<SumData> task2 = Task.Factory.StartNew(() =>
    {
      return downCounter.CountDown(25);
    });


    //Create a new continuation task object that gets executed (starts automatically) when the antedent (preceding) task is completed (either successfully or with an exception)
    Task continuationTask2 = task2.ContinueWith((antecedent) =>
    {
      Console.WriteLine($"Result from Count-Down: {task2.Result.Sum}");
    });

    Console.WriteLine("End of Main Thread");

    Console.ReadKey();
  }
}

class SumData
{
  public long Sum { get; set; }
}

