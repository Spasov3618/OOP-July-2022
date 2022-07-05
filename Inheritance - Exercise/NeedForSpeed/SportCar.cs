namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DefaultFuelConsumption = 10;

        public SportCar(int horcePower, double fuel) : base(horcePower,fuel)
        {
        }
        public override double FuelConsumption =>DefaultFuelConsumption;
    }
}
