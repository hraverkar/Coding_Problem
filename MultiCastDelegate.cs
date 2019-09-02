using System;
/*
 * The delegates can point to multiple method. A delegate that point multiple method is
 * called multi-cast delegate. The "+" operator adds a function to the delegate object
 * and "-" remove an existing function from a delegate object.
 *
 */
namespace ConsoleApp81
{
  internal class Test
  {
    public delegate void Print(int value);
    public static void Main()
    {
      var print =new Print(PrintNumber);
      print += PrintHexaDecimal;
      print += PrintMoney;
      print(1000);

      print -= PrintHexaDecimal;
      print(2000);
    }

    private static void PrintMoney(int money)
    {
      Console.WriteLine("Money: {0:C}", money);
    }

    private static void PrintHexaDecimal(int value)
    {
      Console.WriteLine("Hexadecimal: {0:X}", value);
    }

    private static void PrintNumber(int value)
    {
      Console.WriteLine("Number: {0,-12:N0}", value);
    }
  }
}
