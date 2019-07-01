using System;

namespace ConsoleApp27
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello World!");
      var array = new int[] { 10, 7, 3, 1 };
      var k = 17;
      var p = FindNumber(array, k);
      if (p == k)
      {
        Console.WriteLine("Yes");
      }
      else
      {
        Console.WriteLine("No");
      }
    }

    private static int FindNumber(int[] array, int k)
    {
      var length = array.Length;
      var temp = 0;
      for (int i = 0; i < length; i++)
      {
        for (int j = i + 1; j < length; j++)
        {
          if (array[i] + array[j] == k)
          {
            temp = k;
          }
        }
      }
      return temp;
    }
  }
}
