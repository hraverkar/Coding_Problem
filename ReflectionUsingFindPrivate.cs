using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ConsoleApp101
{
  class Car
  {
    private void Func()
    {
      Console.WriteLine("hello harshal Raverkar");
    }
  }
  internal static class Program
  {
    private static void Main()
    {
      var car = new Car();
      var t = typeof(Car);
      var m = t.GetMethod("Func", BindingFlags.NonPublic|BindingFlags.Instance);
      if (m != null) m.Invoke(car, null);
    }
  }
}


