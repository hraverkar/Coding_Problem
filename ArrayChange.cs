using System;

namespace ConsoleApp23
{
  class Program
  {
    static void Main()
    {
      var list = new int[] { 7, 8, 9,10 };
      var product = 1;
      for (int i = 0; i < list.Length; i++)
      {
        product =product * list[i];
      }

      for (int i = 0; i < list.Length; i++)
      {
        list[i] = product / list[i];
      }

      foreach (var t in list)
      {
        Console.WriteLine(t);
      }
    }
  }
}
