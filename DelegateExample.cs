using System;

namespace ConsoleApp81
{
  internal class Test
  {
    public delegate void Print(string name);

    public static void Main()
    {
      Print pt = Hello;
      pt("Khandwa");
      pt = Hello1;
      pt("Test Harshal Raverkar");
    }

    private static void Hello1(string name)
    {
      Console.WriteLine("Hello Harshal Raverkar " + name);
    }

    private static void Hello(string t)
    {
      Console.WriteLine("Hello Harshal Raverkar " + t);
    }
  }
}
