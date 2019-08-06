using System;

namespace ListExample
{

  internal partial class Program
  {
    public class RemoveEmpolyeeData
    {
      internal void RemoveData()
      {
        Console.WriteLine("Pelase enter the employee ID");
        var ID = Convert.ToInt32(Console.ReadLine());
        var indexofElement = list.FindIndex(e => e.EmployeeID == ID);
        if (indexofElement != -1)
        {
          list.RemoveAt(indexofElement);
        }
        else
        {
          Console.WriteLine("No data found for delete");
        }
        Console.WriteLine("-------**-------------**--------------------**-------------");
        Test t = new Test();
        t.SelectionOption();
      }
    }
  }
}