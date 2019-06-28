using System;
namespace ConsoleApp51
{
  public class Animal
  {
    public virtual void eat()
    {
      Console.WriteLine("Eating ..");
    }
  }

  public class Dog:Animal
  {
    public override void eat()
    {
      Console.WriteLine("Eating bread ...");
    }
  }

  public class Test
  {
    public static void Main()
    {
      Dog dog = new Dog();
      dog.eat();
      Animal animal = new Animal();
      animal.eat();
    }
  }
}
