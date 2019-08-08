using System;
namespace ConsoleApp60
{
  internal class Program
  {
    private static void Main()
    {
      const string str = "ABCD";
      PrintPattern(str);
    }

    private static void PrintPattern(string str)
    {
      var len = str.Length;
      var buf = new char[2*len];
      buf[0] = str[0];
      PrintPatternUtil(str, buf, 1, 1, len);
    }

    private static void PrintPatternUtil(string str, char[] buf, int i, int j, int len)
    {
      while (true)
      {
        if (i == len)
        {
          buf[j] = '\0';
          Console.WriteLine(buf);
          return;
        }
        buf[j] = str[i];
        PrintPatternUtil(str, buf, i + 1, j + 1, len);
        buf[j] = ' ';
        buf[j + 1] = str[i];
        i += 1;
        j += 2;
      }
    }
  }
}
