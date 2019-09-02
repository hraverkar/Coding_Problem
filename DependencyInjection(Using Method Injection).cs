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
  public interface ISet
  {
    void Print();
  }

  public class Service : ISet
  {
    public void Print()
    {
      Console.WriteLine("print harshal Service Class");
    }
  }

  public class Client
  {
    private ISet _set;

    public void Run(ISet serviceServe)
    {
      _set = serviceServe;
      Console.WriteLine("Start harshal");
      _set.Print();
    }
  }

  internal class Program
  {
    public static void Main()
    {
      var cn = new Client();
      cn.Run(new Service());
    }
  }
}