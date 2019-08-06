using System;
using System.Collections.Generic;

namespace ListExample
{
  internal partial class Program
  {
    public class PrintEmpolyeeDetails
    {
      internal void PrintDetails()
      {
        if (list.Count > 0)
        {
          foreach (var Details in list)
          {
            Console.WriteLine(" Name of the Employee : " + Details.Employeename);
            Console.WriteLine(" ID of the Employee : " + Details.EmployeeID);
            Console.WriteLine(" Salary of the Employee : " + Details.Salary);
          }
        }
        else
        {
          Console.WriteLine("No data found in list`");
        }

        Console.WriteLine("-------**-------------**--------------------**-------------");
        Test t = new Test();
        t.SelectionOption();
      }
    }
  }
}
