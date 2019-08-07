using System;

namespace ConsoleApp59
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "HarshalRaverkar";
      int len = str.Length;
      pattern(str, len);
    }

    private static void pattern(string str, int len)
    {
      for(int i=0;i<len;i++)
      {
        int j = len - 1 - i;
        for(int k=0;k<len;k++)
        {
          if (k == i || k == j)
            Console.Write(str[k]);
          else
            Console.Write(" ");
        }
        Console.Write("\n");
      }
    }
  }
}
