namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle( int horcePower, double fuel)
        {
           
            HorcePower = horcePower;
            Fuel = fuel;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;
        public double Fuel { get; set; }
        public int HorcePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            

            Fuel -= kilometers * FuelConsumption;
                


            
        }
    }
}
