using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp57
{
 
  class Test
  {
    public static void Main()
    {
      int n = 9;
      var t = Fib(n);
      Console.WriteLine(t);
    }

    private static int Fib(int n)
    {
      if (n <= 1)
        return n;
      else
      {
        return Fib(n - 1) + Fib(n - 2);
      }

      //************---------------******************---------------//
      int a = 0, b = 1, c = 0;

      for (int i = 2; i <= n; i++)
      {
        c = a + b;
        a = b;
        b = c;
      }
      return b;
    }
  }
}

