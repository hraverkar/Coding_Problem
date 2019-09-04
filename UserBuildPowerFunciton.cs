using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp57
{
  class Program
  {
    static void Main()
    {
      int a = -2;
      int b = 9;
      Stopwatch sw = Stopwatch.StartNew();
      var result = Math.Pow(a, b);
      Console.WriteLine(result);
      sw.Stop();
      Console.WriteLine("Inbuild funciton Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);

      sw = Stopwatch.StartNew();
      var t =ipower(a, b);
      Console.WriteLine(t);
      sw.Stop();
      Console.WriteLine("Using recursion Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
    }

    private static int ipower(int a, int b)
    {
      if (b == 0)
        return 1;
      else if (b % 2 == 0)
        return ipower(a, b / 2) * ipower(a, b / 2);
      else
        return a * ipower(a, b / 2) * ipower(a, b / 2);
    }
  }
}

