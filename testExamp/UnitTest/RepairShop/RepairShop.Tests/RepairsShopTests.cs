using NUnit.Framework;
using System;

namespace RepairShop.Tests
{
    public class Tests
    {
        [TestFixture]
        public class RepairsShopTests
        {
            [Test]
            public void TestCtor()
            {
                Garage garage = new Garage("name", 5);
                Assert.AreEqual("name", garage.Name);
                Assert.AreEqual(5, garage.MechanicsAvailable);
            }
            [Test]
            public void ThrowNameNull()
            {
                Assert.Throws<ArgumentNullException>(() => new Garage(null, 3));
                Assert.Throws<ArgumentNullException>(() => new Garage(String.Empty, 3));

            }
            [Test]
            public void ThrowMechanics()
            {
                Assert.Throws<ArgumentException>(() => new Garage("name", -3));
                Assert.Throws<ArgumentException>(() => new Garage("Pe", 0));

            }
            [Test]
            public void TestCarInGarageCount()
            {
                var garage = new Garage("name", 5);
                Car car = new Car("BMV", 10);
                garage.AddCar(car);
                Assert.AreEqual(garage.CarsInGarage, 1);
            }
            [Test]
            public void ThrowNoAvailableMechanics()
            {
                Garage garage = new Garage("name", 1);
                Car car = new Car("BMV", 10);
                Car car2 = new Car("Opel", 11);
                garage.AddCar(car);
                Assert.Throws<InvalidOperationException>(() => garage.AddCar(car2));
            }
            [Test]
            public void ThrowFixCar()
            {
                Garage garage = new Garage("name", 1);
                Car car = new Car("BMV", 10);

                Assert.Throws<InvalidOperationException>(() => garage.FixCar("Opel"));

            }
            [Test]
            public void TestCarToFix()
            {
                Garage garage = new Garage("name", 1);
                Car car = new Car("BMV", 10);
                garage.AddCar(car);
                garage.FixCar("BMV");
                car.NumberOfIssues = 0;
                Assert.AreEqual(0, car.NumberOfIssues);

            }
            [Test]
            public void ThrowCarToFix()
            {
                Garage garage = new Garage("name", 1);
                Car car = new Car("BMV", 10);
                garage.AddCar(car);

                Assert.Throws<InvalidOperationException>(() => garage.RemoveFixedCar());
            }
            [Test]
            public void CarToFix()
            {
                Garage garage = new Garage("name", 1);
                Car car = new Car("BMV", 10);
                garage.AddCar(car);
                garage.FixCar("BMV");
                garage.RemoveFixedCar();
                Assert.AreEqual(garage.CarsInGarage,0);
            }
            [Test]
            public void TestReport()
            {
                Garage garage = new Garage("name", 1);
                Car car = new Car("BMV", 10);
                garage.AddCar(car);
                var messages = "There are 1 which are not fixed: BMV.";

                Assert.AreEqual(messages, garage.Report());
            }

        }
    }
}