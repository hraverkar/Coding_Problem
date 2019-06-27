using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
  class Program
  {
    
    public static void Main()
    {
      var arrays = new char[] { 'a', 'b', ' ','c', 's',' ', ' ',' ', };
      int CurrentSpaceCount = 0;
      for(int i=0;i<arrays.Length;i++)
      {
        if(arrays[i] == ' ')
        {
          CurrentSpaceCount++;
        }
      }
      Console.WriteLine(CurrentSpaceCount);
    }
  }
}
