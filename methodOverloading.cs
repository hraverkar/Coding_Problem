using System;

namespace ConsoleApp78
{
  internal class Program
  {
    private static void Main()
    {
      const int a = 10;
      const int b = 20;
      const int c = 30;
      const int d = 5;
      const double e = 5.1;
      const double f = 5.2;
      const double g = 5.3;
      const double h = 5.4;
      const double i = 5.5;
      var test = new Test();
      test.Addition(a,b);
      test.Addition(a, b, c);
      test.Addition(a, b, c, d);
      test.Addition(e, f, g, h, i);
    }
  }

  internal class Test
  {
    internal int Addition(int i, int i1)
    {
      return i + i1;
    }
    internal int Addition(int i, int i1,int i2)
    {
      return i + i1 + i2;
    }

    internal void Addition(int a, int b, int c, int d)
    {
      Console.WriteLine(a*b*c*d);
    }
    internal void Addition(double a, double b, double c, double d, double e)
    {
      Console.WriteLine(a +b+c+d+e);
    }
  }
}
