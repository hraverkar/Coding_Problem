using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp156
{
  internal static class Program
  {
    static void Main()
    {
      const string str = "Let's take LeetCode contest";
      var t = FindReverse(str);
      Console.Write(t);

    }

    private static string FindReverse(string str)
    {
      var words = str.Split(' ');
      var sb = new StringBuilder();
      var stack = new Stack<char>();

      foreach (var variable in words)
      {
        foreach (var t in variable)
        {
          stack.Push(t);
        }

        foreach (var c in stack)
        {
          sb.Append(c);
        }

        stack.Clear();
        sb.Append(" ");
      }

      return sb.ToString().TrimEnd();
    }
  }
}
