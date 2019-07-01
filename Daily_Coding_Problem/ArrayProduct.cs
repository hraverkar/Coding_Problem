using System;

namespace ConsoleApp28
{
  class Program
  {
    static void Main()
    {
      var list = new int[] { 3, 2, 1 };
      var product = 1;
      for(int i=0;i<list.Length;i++)
      {
        product *= list[i];
        Console.WriteLine(product);
      }

      for(int i=0;i<list.Length;i++)
      {
        list[i] = product / list[i];
      }
      foreach(var t in list)
      {
        Console.WriteLine(t);
      }
    } 
  }
}
