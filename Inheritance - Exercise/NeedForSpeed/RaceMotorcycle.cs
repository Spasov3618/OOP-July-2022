using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(double fuel, int horcePower) : base(fuel, horcePower)
        {
        }

        public override double FuelConsumption => 8;
    }
}
