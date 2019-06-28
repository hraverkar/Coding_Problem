using System;

namespace ConsoleApp51
{
  public class Program
  {
    public static void Main()
    {
      int val1 = 100;
      int val2;

      keywords1(ref val1);
      Console.WriteLine(val1);

      keywords2(out val2);
      Console.WriteLine(val2);
    }

    private static void keywords2(out int val2)
    {
      val2 = 9;
    }

    private static void keywords1(ref int val1)
    {
      val1 = 7;
    }
  }
}
