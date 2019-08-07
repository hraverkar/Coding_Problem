using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp58
{
  class Program
  {
    public static void Main() {
      string str = "abcd";
      findCollection(str, 0, "");
     }

    private static void findCollection(string str, int v1, string v2)
    {
      if (v1 == str.Length)
        Console.WriteLine(v2);

      for(int i=v1;i<str.Length;i++)
      {
        findCollection(str, i + 1, v2 + "(" + str.Substring(v1, (i + 1) - v1) + ")");
      }
    }
  }
}
