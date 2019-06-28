using System;
namespace ConsoleApp51
{
  public class Empolyee
  {
    private string _name;
    private int _id;

    public string Name
    {
      get {return _name; }
      set { _name = value; }
    }

    public int Id
    {
      get {return _id; }
      set { _id = value; }
    }
  }
  class Program
  {
    public static void Main()
    {
      Empolyee e1 = new Empolyee();
      e1.Id = 101;
      e1.Name = "Harshal Raverkar";
      Console.WriteLine("Employee Id :" + e1.Id);
      Console.WriteLine("Employee Name :" + e1.Name);
    }
  }
}
