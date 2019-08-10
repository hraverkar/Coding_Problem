using System;

/* Interface :
 * Interface is type definition similar to class except that is purely
 * a contract between object and user.
 * interface is nothing but collection of method, property deceleration.
 * interface can declare event and indexer as well
 * deceleration of the interface done in 
 */

namespace ConsoleApp62
{
  public interface IAnimal
  {
    void CanFly();
    void CanRunOnEarth();
    void CanSwim();
    void CanHaveBaby();
    void CanEatHuman();
    void CanEatGrass();
    void CanEatVegetable();
  }

  public interface IAquatic : IAnimal
  {
    new void CanSwim();
    new void CanHaveBaby();
    new void CanEatGrass();

  }

  internal class AquaticAnimal : IAquatic
  {
    public void CanFly()
    {
      throw new NotImplementedException();
    }

    public void CanRunOnEarth()
    {
      throw new NotImplementedException();
    }

    public void CanSwim()
    {
      Console.WriteLine("Fish can swim");
    }

    public void CanHaveBaby()
    {
      Console.WriteLine("Fish can have baby");
    }

    public void CanEatHuman()
    {
      throw new NotImplementedException();
    }

    public void CanEatGrass()
    {
      Console.WriteLine("Fish can eat grass");
    }

    public void CanEatVegetable()
    {
      throw new NotImplementedException();
    }
  }

  internal class Insects : IAnimal
  {
    public void CanFly()
    {
      Console.WriteLine("Insect can fly");
    }

    public void CanRunOnEarth()
    {
      Console.WriteLine("Insect can fly");
    }

    public void CanSwim()
    {
      throw new NotImplementedException();
    }

    public void CanHaveBaby()
    {
      Console.WriteLine("Insect can have baby");
    }

    public void CanEatHuman()
    {
      throw new NotImplementedException();
    }

    public void CanEatGrass()
    {
      Console.WriteLine("Insect can eat grass");
    }

    public void CanEatVegetable()
    {
      Console.WriteLine("Insect can eat vegetable");
    }
  }

  internal class Birds : IAnimal
  {
    public void CanFly()
    {
      Console.WriteLine("Bird can fly");
    }

    public void CanRunOnEarth()
    {
      Console.WriteLine("Bird can run on earth");
    }

    public void CanSwim()
    {
      throw new NotImplementedException();
    }

    public void CanHaveBaby()
    {
      Console.WriteLine("Bird can have baby");
    }

    public void CanEatHuman()
    {
      throw new NotImplementedException();
    }

    public void CanEatGrass()
    {
      Console.WriteLine("Bird can eat grass");
    }

    public void CanEatVegetable()
    {
      Console.WriteLine("Bird can eat vegetables");
    }
  }

  internal class Reptiles : IAnimal
  {
    public void CanFly()
    {
      throw new NotImplementedException();
    }

    public void CanRunOnEarth()
    {
      Console.WriteLine("Snack can run on earth");
    }

    public void CanSwim()
    {
      Console.WriteLine("Snack can swim");
    }

    public void CanHaveBaby()
    {
      Console.WriteLine("Snack can have baby");
    }

    public void CanEatHuman()
    {
      throw new NotImplementedException();
    }

    public void CanEatGrass()
    {
      Console.WriteLine("Snack can eat grass");
    }

    public void CanEatVegetable()
    {
      Console.WriteLine("Snack can eat vegetables");
    }
  }

  internal class Mammals : IAnimal
  {
    public void CanFly()
    {
      throw new NotImplementedException();
    }

    public void CanRunOnEarth()
    {
      Console.WriteLine("Tiger can run on earth");
    }

    public void CanSwim()
    {
      Console.WriteLine("Tiger can swim");
    }

    public void CanHaveBaby()
    {
      Console.WriteLine("Tiger can have baby");
    }

    public void CanEatHuman()
    {
      Console.WriteLine("Tiger can eat human");
    }

    public void CanEatGrass()
    {
      Console.WriteLine("Tiger can eat grass");
    }

    public void CanEatVegetable()
    {
      Console.WriteLine("Tiger can eat vegetables");
    }
  }
  internal class Program
  {
    private static void Main()
    {
      var mammal = new Mammals(); var reptile = new Reptiles(); var bird = new Birds();
      var insect = new Insects(); var aquaAnimal = new AquaticAnimal();
      
        mammal.CanEatGrass(); mammal.CanEatHuman(); mammal.CanEatVegetable(); mammal.CanHaveBaby();
        mammal.CanRunOnEarth(); mammal.CanSwim();
        reptile.CanEatGrass(); reptile.CanEatVegetable(); reptile.CanHaveBaby(); reptile.CanRunOnEarth();
        reptile.CanSwim();
        bird.CanEatGrass(); bird.CanEatVegetable(); bird.CanFly(); bird.CanHaveBaby(); bird.CanRunOnEarth();
        insect.CanEatGrass(); insect.CanEatVegetable(); insect.CanFly(); insect.CanHaveBaby();
        insect.CanRunOnEarth();
        aquaAnimal.CanEatGrass(); aquaAnimal.CanHaveBaby(); aquaAnimal.CanSwim();
    }
  }
}
