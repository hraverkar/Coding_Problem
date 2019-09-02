using System;
using System.Collections.Generic;
using System.Threading;
/*
 *Delegate : delegate are function pointer.
 * it is type safe its have the same parameter System.Delegate
 *
 * Delegate is to use as event 
 *
 *
 */
namespace ConsoleApp76
{
  delegate int Calculator(int n);
  class Program
  {
    private static int _number = 100;

    public static int Add(int n)
    {
      _number += n;
      return _number;
    }

    public static int Multiplication(int n)
    {
      _number += n;
      return _number;
    }

    public static int Division(int n)
    {
      _number += n;
      return _number;
    }

    public static int GetNumber()
    {
      return _number;
    }

    public static void Main()
    {
      Calculator c1 = Add;
      Calculator c2 = Multiplication;
      Calculator c3 = Division;
      c1(12);
      Console.WriteLine("After c1 is : " + GetNumber());
      c2(5);
      Console.WriteLine("After c1 is : " + GetNumber());
      c3(2);
      Console.WriteLine("After c1 is : " + GetNumber());
    }
  }

}
