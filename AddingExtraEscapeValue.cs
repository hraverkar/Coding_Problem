using System;
using System.Text;

namespace ConsoleApp24
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "India has GDP 10% in year 2019";
      StringBuilder sb = new StringBuilder();
      char[] ch = str.ToCharArray();
      for(int i=0;i<ch.Length;i++)
      {
        if (ch[i] == '%')
          sb.Append('%');
        sb.Append(str[i]);
      }
      Console.WriteLine(new String (sb.ToString()));
    }
  }
}
