using System;

namespace ConsoleApp57
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      string str = "AAAABBBCCDAA";
      MaximumOccuringCharater(str);
    }

    private static void MaximumOccuringCharater(string str)
    {
      var input = str.ToLower();
      while (input.Length > 0)
      {
        int count = 0;
        
        for (int i = 0; i < input.Length; i++)
        {
          if (input[0] == input[i])
          {
            count++;
          }
        }
        Console.Write(count);
        Console.Write(input[0]);
        input = input.Replace(input[0].ToString(), string.Empty);
      }
    }
  }
}


