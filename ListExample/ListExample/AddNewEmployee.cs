using System;

namespace ListExample
{
  internal partial class Program
  {
    public class AddNewEmployee
    {
      internal void AddNewData()
      {
        Console.WriteLine("Pelase enter the employee ID");
        var ID = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Pelase enter the employee Name");
        var name  = Console.ReadLine();
        Console.WriteLine("Pelase enter the employee salary");
        var Salary = Convert.ToInt32(Console.ReadLine());

        list.Add(new Empolyee(ID , name, Salary));

        Console.WriteLine("-------**-------------**--------------------**-------------");

        Test t = new Test(); 
        t.SelectionOption();
      }
    }
  }
}
