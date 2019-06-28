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
  public class Program
  {
    public static void Main()
    {
      int n1 = 0, n2 = 1, n3, i, number=15;
      for(int j=2;j<number;j++)
      {
        n3 = n1 + n2;
        Console.Write(n3 + " ");
        n1 = n2;
        n2 = n3;
      }
    }
  }
}
