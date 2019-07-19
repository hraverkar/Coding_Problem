using System;

namespace ConsoleApp56
{
  class Program
  {
    public static void Main()
    {
      int [] arr = { 1, 4, 45, 6, 10, 8 };
      var sum = 22;
      var t = FindTriplateSum(arr,sum );
      Console.WriteLine(t);
    }

    private static bool  FindTriplateSum(int[] arr, int sum)
    {
      for(int i = 0; i < arr.Length-2; i++)
      {
        for(int j =i+1;j<arr.Length-1;j++)
        {
          for(int k=j+1;k<arr.Length;k++)
          {
            if(arr[i] + arr[j]+arr[k] == sum)
            {
              Console.WriteLine("Triplate sum is : " + sum);
              return true;
            }
          }
        }
      }
      return false;
    }
  }
}
