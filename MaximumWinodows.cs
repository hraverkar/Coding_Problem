using System;

namespace ConsoleApp167
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
      int k = 3;
      printKMax(arr, arr.Length, k);
    }

    private static void printKMax(int[] arr, in int arrLength, in int i)
    {
      for (int j = 0; j <= arrLength-i; j++)
      {
        var max = arr[j];
        for (int k = 1; k < i; k++)
        {
          if (arr[j+k] > max)
          {
            max = arr[k + j];
          }
        }
        Console.Write(max +" ");
      }
    }
  }
}
