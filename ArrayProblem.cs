using System;
/*
 * Given a list of numbers and a number k, return whether any two numbers
 * from the list add up to k. For example, given [10, 15, 3, 7] 
 * and k of 17, return true since 10 + 7 is 17. Bonus: Can you do this in one pass?
 
   */
namespace ConsoleApp23
{
  class Program
  {
    public static void Main()
    {
      var arry = new int[] {10, 15, 3, 7};
      var k = 17;
      var t =FindMethod(arry,k);
      Console.WriteLine(t);
    }

    private static bool FindMethod(int[] arry,int k)
    {
      for (int i = 0; i < arry.Length; i++)
      {
        for (int j = 0; j < arry.Length; j++)
        {
          if (arry[i] + arry[j] == k)
            return true;
        }
      }
      return false;
    }
  }
}
