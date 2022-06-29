namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main()
        {
            SportCar sport = new SportCar(100,100);
            Car car = new Car(100,100);
            CrossMotorcycle cross = new CrossMotorcycle(100,100);
            cross.Drive(5);
            car.Drive(5);
            sport.Drive(5);
            RaceMotorcycle family = new RaceMotorcycle(100,100);
            family.Drive(5);
            System.Console.WriteLine(sport.Fuel);
            System.Console.WriteLine(car.Fuel);
            System.Console.WriteLine(cross.Fuel);
            System.Console.WriteLine(family.Fuel);
        }
    }
}
