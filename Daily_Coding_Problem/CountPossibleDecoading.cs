using System;

namespace ConsoleApp49
{
  class Program
  {
    static void Main()
    {
      char[] ch = { '1', '2', '3', '4' };
      int length = ch.Length;
      int t = CountDecoading(ch, length);
      Console.WriteLine(t);
    }

    private static int CountDecoading(char[] ch, int length)
    {
      if (length == 0 || length == 1)
        return 1;
      int count = 0;
      if (ch[length - 1] > '0')
        count = CountDecoading(ch, length - 1);
      if (ch[length - 2] == '1' || (ch[length - 2] == '2' && ch[length - 1] < '7'))
        count += CountDecoading(ch, length - 2);
      return count;
    }
  }
}
