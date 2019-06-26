using System;
using System.Linq;

namespace ConsoleApp23
{
  class Program
  {
    public static void Main()
    {
      var sets = new string[] { "dog", "deer", "deal" };
      var test = from name in sets
                 where name.Contains("de")
                 select name;

      foreach (var t in test)
      {
        Console.WriteLine(t);
      }
    }
  }
}
