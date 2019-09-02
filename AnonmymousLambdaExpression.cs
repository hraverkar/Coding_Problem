using System;
using System.Reflection;

/*
 * Anonymous function is a type of function that does not has name.
 * In other word we can say that function without name is know as anonymous function.
 *   -Lambda Expression 
 *   -Anonymous Methods
 */

namespace ConsoleApp76
{
  class Program
  {
    delegate int Square(int num);
    public static void Main(string[] args)
    {
      Square s = new Square(Test);
      Console.WriteLine(Test(3)); 
    }

    private static int Test(int num)
    {
      var res = num * num;
      return res;
    }
  }
}