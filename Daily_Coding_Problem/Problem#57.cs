using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp74
{
  internal class Program
  {
    private static void Main()
    {
      var str = "the quick brown fox jumps over the lazy dog";
      var k = 10;
      var list = BreakingIntoString(str, k);
      if(list == null)
        Console.WriteLine("unable to break text");
      else
      {
        foreach (var variable in list)
        {
          Console.WriteLine(variable);
        }
      }
    }

    private static List<string> BreakingIntoString(string str, int i)
    {
      var list = new List<string>();
      var sArray = str.Split(" ");
      if (sArray.Any(t => t.Length > i))
      {
        return null;
      }

      var sb = new StringBuilder();
      sb.Append(sArray[0]);
      var k = 1;
      string text;
      while (k < sArray.Length)
      {
        if (sb.Length + sArray[k].Length + 1 <= i)
        {
          sb.Append(" ");
          sb.Append(sArray[k]);
        }
        else
        {
          text = sb.ToString();
          list.Add(text);
          sb = new StringBuilder();
          sb.Append(sArray[k]);
        }

        k++;

      }

      text = sb.ToString();
      list.Add(text);
      return list;
    }
  }
}
