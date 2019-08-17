using System;
using System.Collections.Generic;

namespace ConsoleApp70
{
  internal class Program
  {
    private static void Main()
    {
      //int[] arr = {0, 10, 2, -10, -20};
      int[] arr = {3, 4, -1, 1};
      var length = arr.Length;
      var missing =FindMissing(arr, length);
      Console.WriteLine("The smallest positive missing number is : " + missing);
    }

    private static int FindMissing(int[] arr, int length)
    {
      var shift = Segregate(arr, length);
      var arr2 = new int[length - shift];
      var j = 0;
      for (var i = shift; i < length; i++)
      {
        arr2[j] = arr[i];
        j++;
      }

      return FindMissingPositive(arr2, j);
    }

    private static int FindMissingPositive(IList<int> arr2, int size)
    {
      for (var i = 0; i < size; i++)
      {
        if (Math.Abs(arr2[i]) - 1 < size &&
            arr2[Math.Abs(arr2[i]) - 1] > 0)
          arr2[Math.Abs(arr2[i]) - 1] = -arr2[Math.Abs(arr2[i]) - 1];
      }

      for (var i = 0; i < size; i++)
      {
        if (arr2[i] > 0)
          return i + 1;
      }

      return size + 1;
    }

    private static int Segregate(IList<int> arr, int length)
    {
      var j = 0;
      for (var i = 0; i < length; i++)
      {
        if (arr[i] > 0) continue;
        var temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
        j++;
      }

      return j;
    }
  }
}
