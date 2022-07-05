namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double DefaultFuelConsumption = 3;

        public Car(int horcePower, double fuel) : base(horcePower, fuel)
        {
        }
        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
