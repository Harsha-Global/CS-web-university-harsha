using System;

namespace CSVExample
{
  public class DataProcessor
  {
    public string ChunkName { get; set; }
    public List<string> Chunk { get; set; }
    public Dictionary<string, int> GenderCounts = new Dictionary<string, int>();

    public void ProcessChunk()
    {
      //e.g: "1,De witt,Cowtherd,dcowtherd0@nba.com,Male"

      foreach (string line in Chunk)
      {
        //Skip the iteration if the line is empty
        if (string.IsNullOrEmpty(line)) 
          continue;

        string[] values = line.Split(',');


        //If the line (CSV values) contains at least 5 values
        if (values.Length >= 5)
        {
          //Read the value at index 4 (assuming, it is gender value)
          string gender = values[4].Trim().ToLower();

          //If the gender already exists in the GenderCounts dictionary
          if (GenderCounts.ContainsKey(gender))
          {
            GenderCounts[gender]++;
          }
          else
          {
            GenderCounts.Add(gender, 1);
          }
        }


        //Simulate delay
        Random r = new Random();
        Thread.Sleep(100 * r.Next(2, 5));
      }
    }
  }
}
