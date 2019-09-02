using System;

namespace ConsoleApp78
{
  internal class Test
  {
    public virtual void Hello() // Base class
    {
      Console.WriteLine("Hello Virtual class");
    }
  }

  internal class Testing:Test // Derived class
  {
    public override void Hello()
    {
      Console.WriteLine("Hello Override Harshal");
    }
  }
  
  internal class Program
  {
    public static void Main()
    {
      var t = new Testing();
      t.Hello();
      var p = new Test();
      p.Hello();
    }
  }
}
 