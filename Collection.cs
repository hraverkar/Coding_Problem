using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp76
{
 /* class GenericTest<T>
  {
    public GenericTest(T msg)
    {
      Console.WriteLine(msg);
    }
  }

  class Program
  {
    public static void Main(string[] args)
    {
      var gen  = new GenericTest<string>("This is Harshal raverkar");
      var gen1 = new GenericTest<int>(101);
      var gen2 = new GenericTest<char>('c');
    }
  }*/

 class GenericClass
 {
   public void Show<T>(T msg)
   {
     Console.WriteLine(msg);
   }
 }
 class Program
 {
   public static void Main(string[] args)
   {
     GenericClass genc = new GenericClass();
     genc.Show("Hello Harshal ");
     genc.Show(101);
     genc.Show(1.2345);
     genc.Show('d');
   }
 }
}
