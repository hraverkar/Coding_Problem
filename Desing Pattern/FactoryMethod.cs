using System;
using System.Collections.Generic;

namespace ConsoleApp82
{
  public interface IAirConditioner
  {
    void Operate();
  }
  public class Cooling : IAirConditioner
  {
    private readonly double _temprature;
    public Cooling(double temprature)
    {
      _temprature = temprature;
    }
    public void Operate()
    {
      Console.WriteLine($"Cooling the room to the required temprature of {_temprature} ");
    }
  }

  public class Warming : IAirConditioner
  {
    private readonly double _temprature;
    public Warming(double temprature)
    {
      _temprature = temprature;
    }
    public void Operate()
    {
      Console.WriteLine($"Warming the room to the required temparture of {_temprature}");
    }
  }

  public abstract class AirConditionerFactory
  {
    public abstract IAirConditioner Create(double temprature);
  }

  public class CoolingFactory : AirConditionerFactory
  {
    public override IAirConditioner Create(double temprature)
    {
      return new Cooling(temprature);
    }
  }

  public class WarmingFactory : AirConditionerFactory
  {
    public override IAirConditioner Create(double temprature)
    {
      return new Warming(temprature);
    }
  }

  public enum Actions
  {
    Cooling,
    Warming
  }

  public class AirConditioner
  {
    private readonly Dictionary<Actions, AirConditionerFactory> _factories;
    public AirConditioner()
    {
      _factories = new Dictionary<Actions, AirConditionerFactory>
      {
        {Actions.Cooling, new CoolingFactory() },
        {Actions.Warming, new WarmingFactory() }
      };
    }
    public IAirConditioner EcecuteCreation(Actions action, double temrature)
    {
      return _factories[action].Create(temrature);
    }
  }

  class Program
  {
    static void Main()
    {
      var factory = new AirConditioner().EcecuteCreation(Actions.Cooling, 22.5);
      factory.Operate();
    }
  }
}