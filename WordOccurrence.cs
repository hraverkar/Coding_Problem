using System;
using System.Collections.Generic;

namespace ReturnMaximumOccuringCharacter
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      string str = "HelloHarshalRaverkar";
      MaximumOccuringCharater(str);
    }

    private static void MaximumOccuringCharater(string str)
    {
      var input = str.ToLower();
       while (input.Length > 0)
      {
        int count = 0;
        Console.Write(input[0] + " : ");
        for (int i = 0; i < input.Length; i++)
        {
          if (input[0] == input[i])
          {
            count++;
          }
        }
        Console.WriteLine(count);
        input = input.Replace(input[0].ToString(), string.Empty);
      }

    }
  }
}

