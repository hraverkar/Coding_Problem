using System;
using System.Drawing;

/* class is nothing but a blueprint. it is reference type it can have filed , constructor
 * method property indexer and all.
 * Class is reference type so it will store object in heap; means reference store in heap memory and data
 * store in stack.
 *
 * class default access modifier is internal.
 * other all comes to inside private.
 * Enum and interface is public .
 *
 * Access modifier, static, return type, Main - method name.
 *
 *
 * object is basically block of memory that has been allocated to blueprint
 * A program can create as many object in same class, object are also called instance
 * They can store in array or list.
 * Object are reference type it can store in heap memory
 *
 * var obj = new Object();
 *
 * Interface :
 *  Interface is type definition similar to class except that is purely
 * a contract between object and user.
 * interface is nothing but collection of method, property deceleration.
 * interface can declare event and indexer as well
 * deceleration of the interface done in 
 */

namespace ConsoleApp62
{
  internal class Dog
  {
    private string name_;
    private string breed_;
    private int age_;
    private Color color_;

    public Dog(string name, string breed, int age, Color color)
    {
      name_ = name;
      breed_ = breed;
      age_ = age;
      color_ = color;
    }


    internal string GetName()
    {
      return name_;
    }
    internal string GetBreed()
    {
      return breed_;
    }

    internal int GetAge()
    {
      return age_;
    }

    internal Color GetColor()
    {
      return color_;
    }

    public string ToString()
    {
      return ("Hi my name is " + this.GetName() + " my breed is " + this.GetBreed() + " my age is " + GetAge() + "" +
              " my color is " + GetColor());
    }
  }
  internal class Program
  {
    private static void Main()
    {
      Console.WriteLine("Hello World!");
      var dog = new Dog("Robert","Pug",4,Color.FromArgb(192, 105, 38));
      Console.WriteLine(dog.ToString());
      Console.WriteLine(dog.GetName());
      Console.WriteLine(dog.GetBreed());
      Console.WriteLine(dog.GetAge());
      Console.WriteLine(dog.GetColor());

    }
  }
}
