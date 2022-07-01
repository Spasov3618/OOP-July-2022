namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DefaultFuelConsumption = 10;
        public SportCar(double fuel, int horcePower)
            : base(fuel, horcePower)
        {
            
        }
        

        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
