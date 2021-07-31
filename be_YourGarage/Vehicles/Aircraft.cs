using System;

namespace be_YourGarage.Vehicles
{
  class Aircraft : Vehicle
  {
    public bool IsFlying { get; set; } = false;
    public bool IsLanding { get; set; } = true;

    public Aircraft(string color, 
                    int numberOfPassengers)
    {
      Fuel = 100;
      Capacity = "Full";
      Color = color;
      PassengerOccupancy = numberOfPassengers;
    }

    public override void Refueling()
    {
      Console.Write($"\nRefilling the Aircraft from {Fuel} to ");
      Fuel = 100;
      Console.WriteLine($"{Fuel}.\n");
    }

    public void Flying()
    {
      IsLanding = false;
      IsFlying = true;
      Console.WriteLine($"\nCurrent fuel level is {Fuel}.");
      if (!(Fuel - 10 < 0)) Fuel -= 10;
      Console.WriteLine($"After Flying the fuel level is {Fuel}.");
      Console.WriteLine($"The Aircraft has {PassengerOccupancy} passengers.\n");

      if (Fuel > 90)
      {
        Capacity = "Full";
        Console.WriteLine($"\nThe vehicle is {Capacity}.\n");
      }
      else if (Fuel <= 90 && Fuel > 50)
      {
        Capacity = "over half";
        Console.WriteLine($"\nThe vehicle is {Capacity} way full.\n");
      }
      else if (Fuel <= 50 && Fuel > 0)
      {
        Capacity = "under half";
        Console.WriteLine($"\nThe vehicle is {Capacity} way full.\n");
      }
      else if (Fuel == 0)
      {
        Capacity = "empty";
        Console.WriteLine($"\nThe vehicle is {Capacity}.\n");
      }

    }

    public void Landing()
    {
      IsFlying = false;
      IsLanding = true;
      Console.WriteLine($"\nThe Aircraft is Landing.\n");
    }
  }
}
