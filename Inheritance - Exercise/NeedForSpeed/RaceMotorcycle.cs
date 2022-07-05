namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double DefaultFuelConsumption = 8;

        public RaceMotorcycle(int horcePower, double fuel) : base(horcePower, fuel)
        {
        }
        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
