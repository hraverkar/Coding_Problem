using System;
using System.Collections.Generic;

namespace ConsoleApp57
{
  class Program
  {
    static void Main()
    {
      var medianIndex = 0;
      var res =new int [] { 2, 1, 5, 7, 2, 0, 5 };
      Console.WriteLine("Hello World!");
      var result = new List<double>();
      Array.Sort(res);
      for(int i=1;i<res.Length;i++)
      {
        if(i%2==0)
        {
          var median = (res[medianIndex] + res[medianIndex - 1]) / 2.0;
          result.Add(median);
        }
        else
        {
          result.Add(res[medianIndex]);
          medianIndex++;
        }
      }
      foreach(var t in result)
      {
        Console.WriteLine(t);
      }
    }
  }

