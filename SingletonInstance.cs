using System;

namespace ConsoleApp51
{
  public class Program
  {
    public static void Main()
    {
      Singleton s1 = Singleton.Instance();
      Singleton s2 = Singleton.Instance();

      if(s1 == s2)
      {
        Console.WriteLine("Object are the same instance");
      }
    }
  }

  class Singleton
  {
    private static Singleton _Instance;

    protected Singleton()
    {
    }
    public static Singleton Instance()
    {
      if(_Instance == null)
      {
        _Instance = new Singleton();
      }
      return _Instance;
    }
  }
}
