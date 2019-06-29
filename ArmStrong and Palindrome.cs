using System;


namespace ConsoleApp24
{
  class Program
  {
    static void Main()
    {
      int number = 157;
      int s=0, r;
      while (number > 0)
      {
        r = number % 10;
        s = s * 10 + r;
        number /= 10;
      }
      Console.WriteLine(s);

      int number_for_Armstrong = 371;
      int s1 = 0, r1;
      while(number_for_Armstrong > 0)
      {
        r1 = number_for_Armstrong % 10;
        s1 += (r1 * r1 * r1) ;
        number_for_Armstrong /= 10;
      }

      Console.WriteLine(s1);
    }
  }
}
