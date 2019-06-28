using System;
using System.Text;

namespace ConsoleApp51
{
  public class Program
  {
    public static void Main()
    {
      string str = "My Name is Harshal Raverkar, I am living in Bangalore";
      string str1 = "is";
      string str2 = "living";

      FoundSubString(str, str1, str2);
    
    }

    private static void FoundSubString(string str, string str1, string str2)
    {
      int start, end;
      if(str.Contains(str1) && str.Contains(str2))
      {
        start = str.IndexOf(str1, 0) + str1.Length;
        end = str.IndexOf(str2, start);
       Console.WriteLine( new string( str.Substring(start, end - start)));
      }
    }
  }
}
