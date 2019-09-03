using System;
using System.Collections.Generic;

namespace ConsoleApp82
{
  public interface IVehicleBuilder
  {
    void SetModel();
    void SetEngine();
    void SetTransmission();
    void SetBody();
    void SetAccessories();

    Vehicle GetVehicle();
  }

  public class HeroBuilder :IVehicleBuilder
  {
    readonly Vehicle objVehicle = new Vehicle();

    public Vehicle GetVehicle()
    {
      return objVehicle;
    }

    public void SetEngine()
    {
      objVehicle.Engine = "4 Stroke";
    }

    public void SetAccessories()
    {
      objVehicle.Accessories.Add("Seat Cover");
      objVehicle.Accessories.Add("Rear Mirror");
    }

    public void SetBody()
    {
      objVehicle.Body = "Aluminium";
    }

    public void SetModel()
    {
      objVehicle.Model = "Hero";
    }

    public void SetTransmission()
    {
      objVehicle.Trasmission = "120 km / hr";
    }
  }

  public class HondaBuilder : IVehicleBuilder
  {
    readonly Vehicle objVehicle = new Vehicle();

    public Vehicle GetVehicle()
    {
      return objVehicle;
    }

    public void SetEngine()
    {
      objVehicle.Engine = "4 Stroke";
    }

    public void SetAccessories()
    {
      objVehicle.Accessories.Add("Seat Cover");
      objVehicle.Accessories.Add("Rear Mirror");
      objVehicle.Accessories.Add("Helmate");
    }

    public void SetBody()
    {
      objVehicle.Body = "Plastic";
    }

    public void SetModel()
    {
      objVehicle.Model = "Honda";
    }

    public void SetTransmission()
    {
      objVehicle.Trasmission = "150 km / hr";
    }
  }

  public class Vehicle
  {
    public string Model { get; internal set; }
    public string Engine { get; internal set; }
    public string Trasmission { get; internal set; }
    public string Body { get; internal set; }
    public List<string> Accessories { get; internal set; }

    public Vehicle()
    {
      Accessories = new List<string>();
    }
    public void ShowInfo()
    {
      Console.WriteLine("Model " + Model);
      Console.WriteLine("Engine " + Engine);
      Console.WriteLine("Body " + Body);
      Console.WriteLine("Transmission " + Trasmission);
      Console.WriteLine("Accessories : ");
      foreach(var a in Accessories)
      {
        Console.WriteLine(a);
      }


    }
  }

  public class VehicleCreator
  {
    private readonly IVehicleBuilder objBuilder;
    public VehicleCreator(IVehicleBuilder builder)
    {
      objBuilder = builder;
    }

    public void CreateVehicle()
    {
      objBuilder.SetModel();
      objBuilder.SetEngine();
      objBuilder.SetBody();
      objBuilder.SetTransmission();
      objBuilder.SetAccessories();
    }
    public Vehicle GetVehicle()
    {
      return objBuilder.GetVehicle();
    }
  }

  class Porgram
  {
    static void Main()
    {
      var vehicleCreator = new VehicleCreator(new HeroBuilder());
      vehicleCreator.CreateVehicle();
      var vehicle = vehicleCreator.GetVehicle();
      vehicle.ShowInfo();
      Console.WriteLine("---------------------------------------------");

      vehicleCreator = new VehicleCreator(new HondaBuilder());
      vehicleCreator.CreateVehicle();
      vehicle = vehicleCreator.GetVehicle();
      vehicle.ShowInfo();
    }
  }
}