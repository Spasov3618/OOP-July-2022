namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double DefaultFuelConsumption = 8;
        public RaceMotorcycle(double fuel, int horcePower) 
            : base(fuel, horcePower)
        {
        }

        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
