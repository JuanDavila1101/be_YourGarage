using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_YourGarage.Vehicles
{
  class Watercraft : Vehicle
  {
    public bool IsDriving { get; set; } = false;
    public bool IsBreaking { get; set; } = true;

    public Watercraft(string color, 
                      int numberOfPassengers)
    {
      Fuel = 100;
      Capacity = "Full";
      Color = color;
      PassengerOccupancy = numberOfPassengers;
    }

    public override void Refueling()
    {
      Console.Write($"\nRefilling the Car tank from {Fuel} to ");
      Fuel = 100;
      Console.WriteLine($"{Fuel}.\n");
    }

    public void Driving()
    {
      IsBreaking = false;
      IsDriving = true;
      Console.WriteLine($"\nCurrent fuel level is {Fuel}.");
      if (!(Fuel - 10 < 0)) Fuel -= 10;
      Console.WriteLine($"After driving the fuel level is {Fuel}.");
      Console.WriteLine($"The Car has {PassengerOccupancy} passengers.\n");

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

  }
}
