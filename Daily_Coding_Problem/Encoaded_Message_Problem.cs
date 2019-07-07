using System;

namespace ConsoleApp38
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = "111";
      Console.WriteLine("Hello World!");
      var t = way_to_decode(input, 0);
      Console.WriteLine(t);
    }

    private static int way_to_decode(string input, int v)
    {
      if (v == input.Length)
      {
        return 1;
      }
      var waysToDecode = 0;
      var currentNumber = int.Parse(input[v].ToString());
      if (currentNumber > 0)
      {
        waysToDecode = waysToDecode + way_to_decode(input, v + 1);
      }

      if (v < input.Length - 1)
      {
        currentNumber = int.Parse(input.Substring(v, 2));
        if (currentNumber < 27)
        {
          waysToDecode = waysToDecode + way_to_decode(input, v + 2);
        }
      }

      return waysToDecode;
    }
  }
}
