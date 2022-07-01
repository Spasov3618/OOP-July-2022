namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double DefaultFuelConsumption = 3;
        public Car(double fuel, int horcePower) 
            : base(fuel, horcePower)
        {

        }


        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
