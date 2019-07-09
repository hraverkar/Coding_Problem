using System;

namespace ConsoleApp41
{
  class Program
  {
    /* static void Main(string[] args)
      {
        Console.WriteLine("Hello World!");
        string str = "HelloWorld";
        var len = str.Length;
        while(len > 0)
        {
          Console.Write(str[0] + "=");
          int count  0;
          for(int i=0;i<len;i++)
          {
            if(str[0] == str[i])
            {
              count++;
            }
          }
          Console.WriteLine(count);
          str = str.Replace(str[0].ToString(), string.Empty);
        }
      }*/


    public static void Main(string[] args)
    {
      string input = "HelloWorld";
      
      while (input.Length > 0)
      {
        int count = 0;
        Console.Write(input[0] + " : ");
        for(int i=0;i<input.Length;i++)
        {
          if(input[0] == input[i])
          {
            count++;
          }
        }
        Console.WriteLine(count);
        input = input.Replace(input[0].ToString(), string.Empty);
      }

    }
  }
}
