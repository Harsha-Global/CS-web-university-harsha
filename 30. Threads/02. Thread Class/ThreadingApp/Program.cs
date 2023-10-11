using System.Threading;

class Program
{
  static void Main()
  {
    Thread mainThread = Thread.CurrentThread;
    mainThread.Name = "Main thread";

    ThreadPriority priority = mainThread.Priority; //priority of the thread Lowest | BelowNormal | Normal | AboveNormal | Highest
    Console.WriteLine(mainThread.Name); //Main thread
    Console.WriteLine(priority.ToString()); //Normal
    Console.WriteLine(mainThread.IsAlive); //True (whether the thread started or not)
    Console.WriteLine(mainThread.IsBackground); //False (whether the thread is a background thread or not)
    ThreadState state = mainThread.ThreadState; //Unstarted / Running, WaitSleepJoin etc.
    Console.WriteLine(state.ToString()); //Running
    Console.ReadKey();
  }
}
