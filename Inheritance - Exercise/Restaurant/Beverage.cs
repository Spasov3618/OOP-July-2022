using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double mmilliliters) : base(name, price)
        {
            this.Milliliters = mmilliliters;
        }
        public double Milliliters { get; set; }
    }
}
