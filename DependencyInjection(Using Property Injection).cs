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
  public interface INotificationAction
  {
    void ActOnNotification(string message);
  }

  internal class Test
  {
    private INotificationAction _task;

    public void Notify(INotificationAction at, string message)
    {
      _task = at;
      _task.ActOnNotification(message);
    }
  }

  internal class EventLogWriter : INotificationAction
  {
    public void ActOnNotification(string message)
    {
      Console.WriteLine(message);
    }
  }

  internal class Program
  {
    public static void Main()
    {
      var ewt = new EventLogWriter();
      var test = new Test();
      test.Notify(ewt, "Hello Harshal Raverkar");
    }
  }
}