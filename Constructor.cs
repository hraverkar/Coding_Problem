using System;
namespace ConsoleApp51
{
  public class Employee
  {
    public int id;
    public string name;
    public float salary;
    public Employee(int i, string s, float f)
    {
      id = i;
      name = s;
      salary = f;
    }
    public void Display()
    {
      Console.WriteLine(id + " " + name + " " + salary);
    }
  }
  class Test { 
    public static void Main()
    {
      Employee e1 = new Employee(101,"Harshal",5896f);
      Employee e2 = new Employee(501,"Raverkar",566f);
      e1.Display();
      e2.Display();
    }
  }
}
