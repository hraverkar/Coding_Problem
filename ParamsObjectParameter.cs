using System;
namespace ConsoleApp51
{
  public class Program
  {
    public static void Main()
    {
      Program program = new Program();
      program.Show(2, "Harshal","Hello",4.5,'c');
    }

    private void Show(params Object [] value)
    {
      for(int i=0;i<value.Length;i++)
      {
        Console.WriteLine(value[i]);
      }
    }
  }
}
