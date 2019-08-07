using System;

namespace ConsoleApp58
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello World!");
      string str = "GEEKSFORGEEKS";
      int n = 3;
      printZigZag(str, n);
    }

    private static void printZigZag(string str, int n)
    {
      if (n == 1)
      {
        Console.WriteLine(str);
        return;
      }

      char[] str1 = str.ToCharArray();
      int len = str.Length;

      string[] arr = new string[n];
      int row = 0;
      bool down = true;
      for (int i = 0; i < len; i++)
      {
        arr[row] = arr[row] + str1[i];
        if (row == n - 1)
          down = false;

        else if (row == 0)
          down = true;

        if (down)
          row++;
        else
          row--;
      }
      for (int i = 0; i < n; i++)
      {
        Console.WriteLine(arr[i]);
      }
    }
  }
}
