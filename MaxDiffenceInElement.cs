using System;

namespace ConsoleApp56
{
  class Program
  {
    public static void Main()
    {
      int[] arr = new int[] { 1, 2, 90, 10, 110 };
      int length = arr.Length;
      var MaxDIff = 8;
      MaximumDiffrenceWithTwoElement(arr, length,MaxDIff);
    }

    private static void MaximumDiffrenceWithTwoElement(int[] arr, int length, int maxDIff)
    {
      for(int i=0;i<length;i++)
      {
        for(int j=i+1;j<length;j++)
        {
          if(arr[j] - arr[i] >maxDIff)
          {
            maxDIff = arr[j] - arr[i];
          }
        }
      }
      Console.WriteLine("Max diffrence between to element in given array : " + maxDIff);
    }
  }
}
