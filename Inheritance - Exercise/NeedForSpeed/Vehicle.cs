namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
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
            if (Fuel - kilometers*FuelConsumption >=0)
                {

            Fuel -= kilometers * FuelConsumption;
                }


            
        }
    }
}
