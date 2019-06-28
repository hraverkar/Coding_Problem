using System;
using System.Text;
using System.Threading;
/* Synchronization is a technique that allows only one thread to access 
* the resource for the particular time. No other thread can 
* interrupt until the assigned thread finishes its task.
* 
* ---- Consistency Maintain
----- No Thread Interference

We can use C# lock keyword to execute program synchronously.
It is used to get lock for the current thread, execute the task and then release the lock.
It ensures that other thread does not interrupt the execution until the execution finish.
Here, we are creating two examples that executes asynchronously and synchronously.
*/


  //* With SYNCHRONIZATION *//

  /*using the lock Keyword*/
namespace ConsoleApp51
{
  class Printer
  {
    public void PrintTable()
    {
      lock (this)
      {
        for (int i = 0; i <= 10; i++)
        {
          Thread.Sleep(100);
          Console.WriteLine(i);
        }
      }
    }
  }
  public class Program
  {
    public static void Main()
    {
      Printer p = new Printer();
      Thread t1 = new Thread(new ThreadStart(p.PrintTable));
      Thread t2 = new Thread(new ThreadStart(p.PrintTable));
      t1.Start();
      t2.Start();
    }
  }
}
