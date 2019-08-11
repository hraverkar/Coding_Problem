using System;

namespace ConsoleApp63
{
  internal class Geeks
  {
    public delegate void AddNumber(int a, int b);

    public delegate void SubNumber(int a, int b);

    public void Sum(int a, int b)
    {
      Console.WriteLine("(100+40) = {0} ", a + b);
    }

    public void Substract(int a, int b)
    {
      Console.WriteLine("(100-60) = {0}", a - b);
    }

  }

  internal class Test
  {
    public static void Main()
    {
      var geek = new Geeks();
      var delObj1 = new Geeks.AddNumber(geek.Sum);
      var delObj2 = new Geeks.SubNumber(geek.Substract);

      delObj1(100, 40);
      delObj2(100, 60);
    }
  }
}
