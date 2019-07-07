using System;
using System.Numerics;

namespace ConsoleApp38
{
  class Program
  {
    static void Main(string[] args)
    {
      BigInteger fact = 1; int number = 100;
      for (int i = 1; i <= number; i++)
      {
        fact *= i;
      }
      var p = fact.ToString();
      char[] ch = p.ToCharArray();
      int result = 0;
      for(int i=0;i<ch.Length;i++)
      {
        result += (int)char.GetNumericValue(ch[i]);
      }
      Console.WriteLine(result);
    }
  }
}

