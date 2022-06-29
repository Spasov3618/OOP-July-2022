using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(double fuel, int horcePower) : base(fuel, horcePower)
        {
        }

        public const double DefaultFuelConsumption = 3;

        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
