using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public const double DefaultFuelConsumption = 1.25;
        public Vehicle(double fuel, int horcePower)
        {
            Fuel = fuel;
            HorcePower = horcePower;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;
        public double Fuel { get; set; }
        public int HorcePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            if (this.Fuel - kilometers * FuelConsumption >= 0)
                    {
                this.Fuel -= kilometers * FuelConsumption;

            }
        }
    }
}
