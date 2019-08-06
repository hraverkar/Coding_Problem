using System;
using System.Collections.Generic;
using static ListExample.Program;

namespace ListExample
{
  internal partial class Program
  {
    internal static List<Empolyee> list = new List<Empolyee>();

    public static void Main()
    {
      Console.WriteLine("Please enter the Option");
      Test t = new Test();
      t.SelectionOption();
    }
  }

  class Test {
    public void SelectionOption()
    {
      Console.WriteLine("-------**-------------**--------------------**-------------");
      Console.WriteLine("Press 1 --- for Print the all data from list");
      Console.WriteLine("Press 2 --- Add new data to the list");
      Console.WriteLine("Press 3 --- Remove one data from list");
      Console.WriteLine("Press 4 --- Print after remove or add data to the list");
      Console.WriteLine("-------**-------------**--------------------**-------------");
      var number = Convert.ToInt32(Console.ReadLine());
      switch (number)
      {
        //case for checking the output 
        case 1:
          Console.WriteLine("Print the all details of users");
          PrintEmpolyeeDetails printEmpolyeeDetails = new PrintEmpolyeeDetails();
          printEmpolyeeDetails.PrintDetails();
          break;
        case 2:
          Console.WriteLine("Add New Empolyee to the list");
          AddNewEmployee addData = new AddNewEmployee();
          addData.AddNewData();
          break;
        case 3:
          Console.WriteLine("Add New Empolyee to the list");
          RemoveEmpolyeeData removeEmpolyeeData = new RemoveEmpolyeeData();
          removeEmpolyeeData.RemoveData();
          break;
        case 4:
          Console.WriteLine("Print New Empolyee  with all to the list");
          PrintEmpolyeeDetails printEmpolyeeData = new PrintEmpolyeeDetails();
          printEmpolyeeData.PrintDetails();
          break;
        default:
          Console.WriteLine("You have enterd the wrong input");
          break;
      }
    }
  }
}

