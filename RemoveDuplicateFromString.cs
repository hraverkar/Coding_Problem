using System;
using System.Collections;
using System.Text;

namespace ConsoleApp25
{
  class Program
  {
    static void Main()
    {
      string str = "abbaca";
      var t =RemoveDuplicates(str);
      Console.WriteLine(t);
    }

    private static string RemoveDuplicates(string str)
    {
      var temp = "";
      for(int i=0;i<str.Length;i++)
      {
        if(str[i].ToString() == temp)
        {
          str = str.Replace(temp + str[i], "");
          return RemoveDuplicates(str);
        }
        temp = str[i].ToString();
      }
      return str;
    }
  }
}
