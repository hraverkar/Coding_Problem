using System;
using System.Linq;

namespace ConsoleApp69
{
  internal class Program
  {
    private static void Main()
    {
      var array = new[] {1,2,3,4,5};
      /*foreach (var temp in array)
      {
        product *= temp;
      }*/
      var product = array.Aggregate(1, (current, temp) => current * temp);

      for (var i = 0; i < array.Length; i++)
      {
        array[i] = product / array[i];
      }

      foreach (var variable in array)
      {
        Console.WriteLine(variable);
      }
    }
  }
}
