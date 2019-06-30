using System;
using System.Text;

namespace ConsoleApp26
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 9;
      var a =Diamond(i);
      Console.Write(a);
    }

    private static string Diamond(int i)
    {
      if (i < 0 || i % 2 == 0) return null;
      var sb = new StringBuilder().Append(Environment.NewLine)
        .Append('*', i).Append(Environment.NewLine);
      for(int x=i;i>=1;--x)
      {
        sb.Append(' ', x - i).Append('*', i).Append(Environment.NewLine)
          .Insert(0, "*", i).Insert(0, " ", x - i).Insert(0, Environment.NewLine);
        i -= 2;
      }
      return sb.ToString();
    }
  }
}
