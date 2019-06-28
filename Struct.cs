using System;
namespace ConsoleApp51
{
  public struct Rectangle
  {
    public int width, height;
  }
  class Program
  {
    public static void Main()
    {
      Rectangle r = new Rectangle();
      r.height = 11;
      r.width = 25;
      Console.WriteLine("Area of Rectangle :" + (r.width * r.height));
    }
  }
}
