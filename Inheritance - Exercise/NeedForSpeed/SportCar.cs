using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(double fuel, int horcePower) : base(fuel, horcePower)
        {
            
        }
        public const double DefaultFuelConsumption = 10;

        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
