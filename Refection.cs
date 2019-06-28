using System;
namespace ConsoleApp51
{
  public class Program
  {
    public static void Main()
    {
      dynamic a = 'H';
      Type type = a.GetType();
      Console.WriteLine(type);

      Type p = typeof(System.String);
      Console.WriteLine(p.Assembly);
      Console.WriteLine(p.FullName);
      Console.WriteLine(p.IsEnum);
      Console.WriteLine(p.BaseType);
    }
  }
}
