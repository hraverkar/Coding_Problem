using System;
namespace ConsoleApp51
{
  internal class Student
  {
   public int id;
   public string name;
    
    public void insert(int i, string n)
    {
      id = i;
      name = n;
    }
    public void Display()
    {
      Console.WriteLine(id + " " + name);
    }

  }
  public class Program
  {
    public static void Main()
    {
      Student student = new Student();
      student.id = 101;
      student.name = "Harshal";
      student.insert(105, "Harshal Raverkar");
      student.Display();
      student.insert(502, "Bangalore");
      student.Display();
    }
  }
}
