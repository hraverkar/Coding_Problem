using System;
using System.Threading;

namespace ConsoleApp51
{
  public class Program
  {
    public static void Main()
    {
      var myThread = new MyThread();
      Thread t1 = new Thread(new ThreadStart(myThread.Thread1));
      Thread t2 = new Thread(new ThreadStart(myThread.Thread1));
      t1.Name = "Harshal";
      t2.Name = "Raverkar";
      t1.Priority = ThreadPriority.Highest;
      t2.Priority = ThreadPriority.Lowest;
      t1.Start();
      t1.Join();
      t2.Start();
    }
  }

  internal class MyThread
  {
    public void Thread1()
    {
      for(int i=0;i<10;i++)
      {
        Console.WriteLine(i);
        Thread.Sleep(200);
      }
    }
  }
}
