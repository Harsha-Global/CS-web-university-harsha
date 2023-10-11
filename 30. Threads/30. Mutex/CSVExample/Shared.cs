using System;

namespace CSVExample
{
  public class Shared
  {
    public static Mutex mutex { get; set; } // Mutex object to synchronous threads while displaying processed data in output
    public static string FilePath {  get; set; }
    public static int ChunkSize { get; set; }
    public static int MaxConcurrency { get; set; }

    static Shared()
    {
      mutex = new Mutex();
      FilePath = "data.csv";
      ChunkSize = 100;
      MaxConcurrency = 3;
    }
  }
}
