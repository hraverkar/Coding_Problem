/*
 * Algorithm to find the common element in given three sorted arrays
 */
using System;

namespace ConsoleApp56
{
  class Program
  {
    public static void Main()
    {
      int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      int[] arr2 = { 1, 3, 5, 6, 7, 8, 12 };
      int[] arr3 = { 2, 3, 4, 5, 8, 9 };
      findCommon(arr1,arr2,arr3);
    }

    private static void findCommon(int[] arr1, int[] arr2, int[] arr3)
    {
      int i=0 ,j=0,k= 0;
      while (i < arr1.Length && j < arr2.Length && k < arr3.Length)
      {
        if ((arr1[i] == arr2[j]) && (arr2[j] == arr3[k]))
        {
          Console.WriteLine(arr1[i] + " ");
          i++; j++; k++;
        }
        else if ((arr1[i] <= arr2[j]) && (arr1[i] <= arr3[k]))
        {
          i++;
        }
        else if ((arr2[j] <= arr1[i]) && (arr2[j] <= arr3[k]))
        {
          j++;
        }
        else
        {
          k++;
        }
      }
    }
  }
}
