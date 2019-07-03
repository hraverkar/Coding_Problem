using System;

namespace ConsoleApp33
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var i = 13;
     // var t=fibbonaci_Series(i);
      Console.WriteLine(fibbonaci_Series(i));
    }

    private static int fibbonaci_Series(int i)
    {
      if (i <= 1) return i;
      return fibbonaci_Series(i - 1) + fibbonaci_Series(i - 2);
    }
  }
}
