using System;

namespace ConsoleApp61
{
  class Program
  {
    private const int AsciiSize = 256;

    private static void Main()
    {
      const string str = "HARSHAL RAVERKAR";
      Console.WriteLine(("Maximum occuring character is : " +  GetMaxOccuranceChar(str)));
      Console.WriteLine("Hello World!");
    }

    private static char GetMaxOccuranceChar(string str)
    {
      var count = new int[AsciiSize];
      var len = str.Length;
      for (var i = 0; i < len; i++)
      {
        count[str[i]]++;
      }

      var max = -1;
      var result =' ';
      for (var i = 0; i <len; i++)
      {
        if (max < count[str[i]])
        {
          max = count[str[i]];
          result = str[i];
        }
      }
      return result;
    }
  }
}
