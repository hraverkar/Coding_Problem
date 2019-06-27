using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
  class Program
  {
    public static void Main()
    {
      string str = "Harslvek";
      var t = UniqueChars(str);
      if(t)
        Console.WriteLine("Having unique keyword");
      else
      {
        Console.WriteLine("Not Having unique keyword");
      }
    }

    private static bool UniqueChars(string str)
    {
      for(int i=0;i<str.Length-1;i++)
      {
        for(int j=i+1;j<str.Length;j++)
        {
          if (str[i] == str[j])
            return false;
        }
      }
      return true;
    }
  }
}
