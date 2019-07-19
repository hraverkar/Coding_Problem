using System;

namespace ConsoleApp56
{
  class Program
  {
    public static void Main()
    {
      int[] arr = new int[] { 0, 1, 0, 1, 1, 1 };
      int length = arr.Length;
      Segrigate(arr, length);
    }

    private static void Segrigate(int[] arr, int length)
    {
      int count = 0;
      for(int i=0;i<length;i++)
      {
        if (arr[i] == 0)
          count++;
      }

      for (int i = 0;i<count;i++)
      {
        arr[i] = 0;
      }

      for(int i=count;i<length;i++)
      {
        arr[i] = 1;
      }


      foreach(var t in arr)
      {
        Console.WriteLine(t);
      }
      
    }
  }
}
