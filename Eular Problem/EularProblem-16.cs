using System;
using System.Numerics;

namespace ConsoleApp38
{
  class Program
  {
    static void Main()
    {
      int result = 0;
      string val = BigInteger.Pow(2, 1000).ToString();
      Console.WriteLine(val);

      char[] ch = val.ToCharArray();
      var length = ch.Length;
      for(int i =0;i<length;i++)
      {
        result = result + (int)char.GetNumericValue(ch[i]);
      }
      Console.WriteLine("The sum of digit is" + result);
    }
  }
}
