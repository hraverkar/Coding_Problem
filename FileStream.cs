using System;
using System.IO;

namespace ConsoleApp51
{
  class Program
  {
    public static void Main()
    {
      FileStream f = new FileStream(@"F:\Temp\test.txt", FileMode.OpenOrCreate);
      for (int i = 65; i <= 90; i++)
      {
        f.WriteByte((byte)i);
      }
      f.Close();
    }
  }
}
