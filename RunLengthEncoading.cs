using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
  class Program
  {
    public static void Main()
    {
      string str = "aaabcc";
      while(str.Length > 0)
      {
        Console.Write(str[0]);
        int count = 0;
        for(int j =0;j<str.Length;j++)
        {
          if(str[0] == str[j])
          {
            count++;
          }
        }
        Console.Write(count);
        str = str.Replace(str[0].ToString(), string.Empty);
      }   
    }
  }
}
