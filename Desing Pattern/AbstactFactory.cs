using System;

namespace ConsoleApp82
{
  abstract class ContinentFactory
  {
    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
  }

  class AfricaFactory : ContinentFactory
  {
    public override Herbivore CreateHerbivore()
    {
      return new Wildebeest();
    }
    public override Carnivore CreateCarnivore()
    {
      return new Lion();
    }
  }

  class AmericanFactory : ContinentFactory
  {
    public override Herbivore CreateHerbivore()
    {
      return new Bison();
    }
    public override Carnivore CreateCarnivore()
    {
      return new Wolf();
    }
  }

  internal class Wolf : Carnivore
  {
    public override void Eat(Herbivore h)
    {
      Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
    }
  }

  internal class Bison : Herbivore
  {
  }

  internal class Lion : Carnivore
  {
    public override void Eat(Herbivore h)
    {
      Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
    }
  }

  internal class Wildebeest : Herbivore
  {
  }

  abstract class Carnivore
  {
    public abstract void Eat(Herbivore h);
  }

  abstract class Herbivore
  {
  }

  class AnimalWorld
  {
    private Herbivore _herbivore;
    private Carnivore _carnivore;

    public AnimalWorld(ContinentFactory factory)
    {
      _carnivore = factory.CreateCarnivore();
      _herbivore = factory.CreateHerbivore();
    }

    public void RunFoodChain()
    {
      _carnivore.Eat(_herbivore);
    }
  }

  class Program
  {
    public static void Main()
    {
      ContinentFactory africa = new AfricaFactory();
      AnimalWorld world = new AnimalWorld(africa);
      world.RunFoodChain();

      ContinentFactory america = new AmericanFactory();
      world = new AnimalWorld(america);
      world.RunFoodChain();
    }
  }

}