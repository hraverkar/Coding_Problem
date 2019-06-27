using System;

/*  This is example of Hierarchical inheritance.
 *  in that there is One Base Class and Many derived class which extand from base class only ;
 *  
 *  Example - 
 *  Class A
 *  Class B : A
 *  Class C : A
 *  Class D : A
 *  
 */
namespace ConsoleApp50
{

  class A  // this is base class
  {
    public string Cradit()
    {
      return "Balance is cradited";
    }
  }
  class B : A    // this is derived class
  {
    public string Debit()    
    {
      var t = Cradit();
      Console.WriteLine(t);
      return "balance is debited"; 
    }
  }

  class C : A
  {
    public string Test()
    {
     return "Hello Harshal Raverkar";
    }
  }

  class D : A
  {
    public string Test1()
    {
      return "Hello Harshal Raverkar 123";
    }
  }
  class Program
  {
    static void Main()
    {

      var t = new A();
      t.Cradit();

      var r = new D();
      r.Test1();
    }
  }
}


