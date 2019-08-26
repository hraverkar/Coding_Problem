using System;
using System.Collections.Generic;

namespace ConsoleApp74
{
  internal class Program
  {
    private static void Main()
    {
      Console.WriteLine("Hello World!");
      var watch = System.Diagnostics.Stopwatch.StartNew();
      var arr = new[] {13, 18, 25, 2, 8, 10};
      var x = 8;
      var len = arr.Length;
      FindIndex(arr, len, x);
      watch.Stop();
      Console.WriteLine("Time taken: {0}ms", watch.Elapsed.TotalMilliseconds);
    }

    private static void FindIndex(IReadOnlyList<int> arr, int len, int x)
    {
      var temp = 0;
      for (var i = 0; i < len; i++)
      {
        if (arr[i] == x)
        {
          temp = i;
        }
      }
      Console.WriteLine("Index of number is : " + temp);
    }
  }
}
