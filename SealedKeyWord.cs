using System;
namespace ConsoleApp51
{
  sealed public class Animal
  {
    public void Eat()
    {
      Console.WriteLine("Eating ..");
    }
  }

  public class Dog : Animal
  {
    public void bark()
    {
      Console.WriteLine("Barking ..");
    }
  }

  public class Test
  {
    public static void Main()
    {
      Dog dog = new Dog();
      dog.Eat();
      dog.bark();
      
    }
  }
}
