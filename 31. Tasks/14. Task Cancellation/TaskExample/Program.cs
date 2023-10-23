using System.Threading.Tasks;
using System.Diagnostics;

class UpCounter
{
  public long CountUp(int count, CancellationToken token)
  {
    long sum = 0;
    Console.WriteLine("\nCount-Up starts");
    for (int i = 1; i <= count; i++)
    {
      token.ThrowIfCancellationRequested(); //throw new OperationCanceledException

      Console.Write($"i = {i}, ");
      sum += i;
      Task.Delay(300).Wait();

    }
    Console.WriteLine("\nCount-Up ends");

    //throw new Exception("Unable to generate sum in Count-Up method");
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

    //Create CancellationTokenSource class object (used to cancel a task)
    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

    //create and start task
    //Create a new continuation task object that gets executed (starts automatically) when the antedent (preceding) task is completed (either successfully or with an exception)
    Task.Run(() =>
    {
      return upCounter.CountUp(20, cancellationTokenSource.Token);
    }, cancellationTokenSource.Token).ContinueWith((antecedent) =>
    {
      if (antecedent.Status == TaskStatus.Canceled)
      {
        Console.WriteLine("Count-Up Task Cancelled");
        return -1;
      }
      else if (antecedent.Status == TaskStatus.Faulted)
      {
        Console.WriteLine($"Exception occurred {antecedent.Exception.InnerExceptions.First().Message}");
        return -1;
      }
      else if (antecedent.Status == TaskStatus.RanToCompletion)
      {
        return antecedent.Result;
      }
      else
      {
        return -1;
      }
    }).ContinueWith(antecedent =>
    {
      if (antecedent.Result != -1)
      {
        Console.WriteLine($"Result from Count-Up: {antecedent.Result}");
      }
    });

    //Create a new continuation task object that gets executed (starts automatically) when the antedent (preceding) task is completed (either successfully or with an exception)
    Task.Factory.StartNew(() =>
    {
      return downCounter.CountDown(25);
    }).ContinueWith((antecedent) =>
    {
      Console.WriteLine($"Result from Count-Down: {antecedent.Result.Sum}");
    });


    //Cancel the task1
    Task.Delay(4000).Wait();
    cancellationTokenSource.Cancel();

    Console.WriteLine("End of Main Thread");

    Console.ReadKey();
  }
}

class SumData
{
  public long Sum { get; set; }
}

