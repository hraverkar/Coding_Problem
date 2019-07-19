/*
 * Algorithm to find the common element in given three sorted arrays
 */
using System;
using System.Collections.Generic;

namespace ConsoleApp56
{
  class Program
  {
    public static void Main()
    {
      char[] nuts = { '$', '%', '&', 'x', '@' };
      char[] bolts = { '%', '@', 'x', '$', '&' };
      Match(nuts, bolts);
    }

    private static void Match(char[] nuts, char[] bolts)
    {
      Dictionary<char, int> dict = new Dictionary<char, int>();
      for(int i=0;i<nuts.Length;i++)
      {
        dict.Add(nuts[i], i);
      }

      for(int i=0;i<bolts.Length;i++)
      {
        char bolt = bolts[i];
        if(dict.ContainsKey(bolt))
        {
          nuts[i] = bolts[i];
        }
        else
        {
          Console.WriteLine("for bolt " + bolt + " no nut is present ");
          return;
        }
      }
     Console.WriteLine("Matched nuts and bolts are: ");
      foreach(var t in nuts)
      {
        Console.Write( "Current state : " +t);
      }
      foreach (var p in bolts)
      {
        Console.Write("\n After matching state : " +p);
      }
    }
  }
}
