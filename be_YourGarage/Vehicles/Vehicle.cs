using System;

namespace be_YourGarage.Vehicles
{
  abstract class Vehicle
  {
    public int Fuel { get; set; } = 0;
    public string Capacity { get; set; }
    public string Color { get; set; }
    public int PassengerOccupancy { get; set; }

    public abstract void Refueling();
  }
}
