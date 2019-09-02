using ConsoleApp81;
using System;
/*
 *  Dependency Injection (DI) is a software design pattern that allow us to develop
 * loosely coupled code . Di is a great way to reduce tight coupling between software
 * components.
 * Di is also  enables us to better manage future changes and other
 * complexity in our software.
 *
 *
 * Suppose your client class needs to use two service classes.
 * then the best you can do s to make your client class aware of abstraction.
 *
 *
 */
namespace ConsoleApp81
{
  public interface IText
  {
    void Print();
  }

  internal class Format : IText
  {
    public void Print()
    {
      Console.WriteLine("Here is the text format");
    }
  }

  public class Test
  {
    private readonly IText _text;
    public Test(IText t1)
    {
      this._text = t1;
    }
    public void Print()
    {
      _text.Print();
    }
  }

  internal class Program
  {
    public static void Main()
    {
      var cj =new Test(new Format());
      cj.Print();
    }
  }
  
    
  
}