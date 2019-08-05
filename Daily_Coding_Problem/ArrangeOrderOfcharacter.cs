/*
 * given the array ['G', 'B', 'R', 'R', 'B', 'R', 'G'], 
 * it should become ['R', 'R', 'R', 'G', 'G', 'B', 'B'].
 */
using System;

namespace ConsoleApp56
{
  class Program
  {
    public static void Main()
    {
      var t = new char[] { 'G', 'B', 'R', 'R', 'B', 'R', 'G' };
      //Array.Sort(t);
      for(int i=0;i<t.Length;i++)
      {
        for(int j=i+1;j<t.Length;j++)
        {
          if(t[i] < t[j])
          {
            var temp = t[i];
            t[i] = t[j];
            t[j] = temp;
          }
        }
      }
      Console.WriteLine("Hello Sorted order is ");
      foreach (var p in t)
      {
        Console.WriteLine(p);
      }

    }
  }
}
