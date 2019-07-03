using System;

namespace ConsoleApp31
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello World!");
      var number = 100;
      SquareofSum(number);
    }

    private static void SquareofSum(int number)
    {
      //The square of the sum of the first ten natural numbers is,
      var m = number*(number + 1) / 2;
      var p = Math.Pow(m, 2);
      Console.WriteLine(m);
     // The sum of the squares of the first ten natural numbers is,
      var n = number * (number + 1) * (2 * number + 1) / 6;
      Console.WriteLine(n);
      var diffrence = p - n;
      Console.WriteLine(diffrence);
    }
  }
}
