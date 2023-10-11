﻿using System;

namespace CSVExample
{
  public class Shared
  {
    public static object LockObject { get; set; }
    public static string FilePath {  get; set; }
    public static int ChunkSize { get; set; }
    public static int MaxConcurrency { get; set; }

    static Shared()
    {
      LockObject = new object();
      FilePath = "data.csv";
      ChunkSize = 100;
      MaxConcurrency = 3;
    }
  }
}
