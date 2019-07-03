using System;

namespace ConsoleApp32
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello World!");
      var array = new int[] { 1,2,0 };// should give 2.The input[1, 2, 0] should give 3
      var t = Missing(array);
      //Array.Sort(array);
      Console.WriteLine(t);

    }

    public static int Missing(int[] a)
    {
      // the idea is to put all values in array on their ordered place if possible
      for (int i = 0; i < a.Length; i++)
      {
        CheckArrayAtPosition(a, i);
      }

      for (int i = 0; i < a.Length; i++)
        if (a[i] != i + 1)
          return i + 1;
      return a.Length + 1;
    }

    private static void CheckArrayAtPosition(int[] a, int i)
    {
      var currentValue = a[i];
      if (currentValue < 1) return; // do not touch negative values because array indexes are non-negative
      if (currentValue > a.Length) return; // do not touch values that are bigger than array length because we will not locate them anyway
      if (a[currentValue - 1] == currentValue) return; // do not need to change anything because index contain correct value already
      Swap(a, i, currentValue - 1);
      CheckArrayAtPosition(a, i); // now current position value is updated so we need to check current position again
    }

    private static void Swap(int[] a, int i, int j)
    {
      int temp = a[i];
      a[i] = a[j];
      a[j] = temp;
    }
  }
}
