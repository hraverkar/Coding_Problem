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
    public delegate void Test();

    public static void Main(string[] args)
    {
      Test test = delegate()
      {
        Console.WriteLine("test");
      };
      test();
    }
  }
}