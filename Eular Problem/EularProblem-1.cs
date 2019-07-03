using System;

namespace ConsoleApp33
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var n = 1000;
      int temp = 0;
      int temp1 = 0;
      for(int i =1;i<n;i++)
      {
        if(i % 3 == 0)
        {
          Console.WriteLine(i);
          temp = temp + i;
        }
        else if(i % 5 == 0)
        {
          temp1 = temp1 + i;
        }
      }

      var p = temp + temp1;
      Console.WriteLine(p);

    }
  }
}
