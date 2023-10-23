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
    Task<long> task1 = Task.Run(() => {
      return upCounter.CountUp(20);
    });

    Task<SumData> task2 = Task.Factory.StartNew(() => {
      return downCounter.CountDown(25);
    });

    //Wait for completion of both tasks
    int compledTaskIndex = Task.WaitAny(task1, task2);

    if (compledTaskIndex == 0 )
    {
      Console.WriteLine($"Result from Count-Up: {task1.Result}");
    }
    else
    {
      Console.WriteLine($"Result from Count-Down: {task2.Result.Sum}");
    }
    //Read return value of tasks
    //Console.WriteLine($"Result from Count-Up: {task1.Result}");
    //Console.WriteLine($"Result from Count-Down: {task2.Result.Sum}");

    //SumData s = task2.Result;
    Console.ReadKey();
  }
}

class SumData
{
  public long Sum { get; set; }
}

