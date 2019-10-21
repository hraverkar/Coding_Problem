using System;

namespace ConsoleApp153
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "Hello Harshal Raverkar";
      var t = str.Split(' ');
      for (int i = t.Length-1; i >= 0 ; i--)
      {
        Console.Write(t[i]+' ');
      }
    }
  }
}
