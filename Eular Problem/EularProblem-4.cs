using System;
using System.Diagnostics;

class Program
{
  static void Main(string[] args)
  {
    Stopwatch timer = new Stopwatch();
    timer.Start();

    int num1 = 0;
    int num2 = 0;
    int answer = 0;

    for (num1 = 100; num1 < 999; num1++)
    {
      for (num2 = 100; num2 < 999; num2++)
      {
        int x = num1 * num2;

        if (isPalindrome(x))
        {
          if (x > answer)
          {
            answer = x;
          }
        }
      }
    }

    timer.Stop();
    Console.WriteLine("Answer: {0} which is made from {1}, and {2}\n\nIt took {3} seconds to find the answer.", answer, num1, num2, timer.Elapsed.ToString("ss\\.ff")); //Why are num1 and num2 showing up incorrectly?
    Console.ReadLine();
  }

  private static bool isPalindrome(int x)
  {
    int n = x;
    int rev = 0;
    int digit = 0;
    while (n > 0)
    {
      digit = n % 10;
      rev = rev * 10 + digit;
      n = n / 10;

      if (n == rev)
      {
        return true;
      }
    }
    return false;
  }
}
