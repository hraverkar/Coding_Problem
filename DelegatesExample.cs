using System;
using System.Runtime.Serialization;

namespace ConsoleApp51
{
  public class Progarm
  {
    public delegate string Print(string Message);
    public delegate void PrintDelegate(int value);
    public static void Main()
    {
      Print p = new Print(Test);
      Console.WriteLine( p("Hello Harshal Raverkar"));

      PrintDelegate printDelegate = new PrintDelegate(printNumber);
      printDelegate(1000);
    }

    private static void printNumber(int value)
    {
      Console.WriteLine(value);
    }

    private static string Test(string Message)
    {
      return Message;
    }
  }
}
