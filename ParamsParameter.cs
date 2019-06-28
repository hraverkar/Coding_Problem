using System;
namespace ConsoleApp51
{
  public class Program
  {
    public static void Main()
    {
      Program program = new Program();
      program.Show(2, 4, 6, 8, 10, 12, 14);
    }

    private void Show(params int [] value)
    {
      for(int i=0;i<value.Length;i++)
      {
        Console.WriteLine(value[i]);
      }
    }
  }
}
