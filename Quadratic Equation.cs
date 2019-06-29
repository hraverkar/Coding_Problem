using System;


namespace ConsoleApp24
{
  class Program
  {
    static void Main()
    {
      double a= 2.3;
      double b = 4;
      double c = 5.6;
      double discrimant, root1, root2, realPart, imaginaryPart;
      discrimant = b * b - 4 * a * c;

      if(discrimant > 0)
      {
        root1 = (-b + Math.Sqrt(discrimant)) / (2 * a);
        root2 = (-b + Math.Sqrt(discrimant)) / (2 * a);
        Console.WriteLine("root1 = %.2lf and root2 = %.2lf" + root1 + root2);
      }
      else if(discrimant ==0)
      {
        root1 = root2 = -b / (2 * a);
        Console.WriteLine("root1 = root2 = %.2lf;"+ root1);
      }
      else
      {
        realPart = -b / (2 * a);
        imaginaryPart = Math.Sqrt(-discrimant) / (2 * a);
        Console.WriteLine("root1 = %.2lf+%.2lfi and root2 = %.2f-%.2fi" + realPart +","+ imaginaryPart + "," + realPart + "," + imaginaryPart);
      }
    }
  }
}
