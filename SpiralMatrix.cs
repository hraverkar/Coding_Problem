using System;

namespace ConsoleApp82
{
  internal class Program
  {
    private static void Main()
    {
      int[,] arr = {{1, 2, 3, 4, 5}, {6, 7, 8, 9, 10}, 
        {11, 12, 13, 14, 15}, {16, 17, 18, 19, 20}};
      var R = 4;
      var C = 5;
      SpiralMatrix(R, C, arr);

    }

    private static void SpiralMatrix(int r, int c, int[,] arr)
    {
      int k = 0, l=0;
      while (k < r && l < c)
      {
        int i;
        for ( i = l; i < c; ++i)
        {
          Console.WriteLine(arr[k,i] +" ");
        }

        k++;

        for ( i = k; i < r; ++i)
        {
          Console.WriteLine(arr[i,c-1] +" ");
        }

        c--;

        if (k < r)
        {
          for (i = c - 1; i >= l; --i)
          {
            Console.WriteLine(arr[r-1,i] +" ");
          }

          r--;
        }

        if (l < c)
        {
          for ( i =r-1; i>=k;--i)
          {
            Console.WriteLine(arr[i,l]+ " ");
          }

          l++;
        }
      }
    }
  }
}
