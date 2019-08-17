using System;
using System.Collections.Generic;

namespace ConsoleApp69
{
  internal class Program
  {
    private static void Main()
    {
      var array = new[] {1, 8, 9, 1};
      const int k = 17;
      var test = new Test();
      var c = test.FindNumber(array, k);
      Console.WriteLine(c == k ? "Yes" : "No");
    }
  }

  internal class Test
  {
    internal int FindNumber(IReadOnlyList<int> array, int i)
    {
      var length = array.Count;
      var temp = 0;
      for (var j = 0; j < length; j++)
      {
        for (var k = j + 1; k < length; k++)
        {
          if (array[j] + array[k] == i)
            temp = i;
        }
      }

      return temp;
    }
  }
}
