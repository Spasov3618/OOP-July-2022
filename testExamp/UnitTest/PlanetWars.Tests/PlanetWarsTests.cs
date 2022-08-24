using NUnit.Framework;
using System;

namespace PlanetWars.Tests
{
    public class Tests
    {
        [TestFixture]
        public class PlanetWarsTests
        {
            [Test]
            public void TestAmaunt()
            {
                Planet planet = new Planet("name", 100);
                planet.Profit(100);
                Assert.AreEqual(planet.Budget, 200);
            }
            [Test]
            public void TestThrowSpeend()
            {
                Planet planet = new Planet("name", 100);
                Assert.Throws<InvalidOperationException>(() => planet.SpendFunds(200));

            }
            [Test]
            public void SpeendOk()
            {

                Planet planet = new Planet("name", 100);
                planet.SpendFunds(40);
                Assert.AreEqual(planet.Budget, 60);
            }
            [Test]
            public void ThrowWeaponAddWhenWeaponIsAdd()
            {

                Planet planet = new Planet("name", 100);
                Weapon weapon = new Weapon("name", 100, 20);
                planet.AddWeapon(weapon);
                Assert.Throws<InvalidOperationException>(() => planet.AddWeapon(weapon));

            }
            [Test]
            public void RemoveWeapon()
            {
                Planet planet = new Planet("name", 100);
                Weapon weapon = new Weapon("bla", 100, 20);
                planet.RemoveWeapon("bla");
                Assert.AreEqual(planet.Weapons.Count, 0);
            }
            [Test]
            public void RemoveWeaponNoName()
            {
                Planet planet = new Planet("name", 100);
                Weapon weapon = new Weapon("name", 100, 20);
                planet.RemoveWeapon("name");


                Assert.AreEqual(planet.Weapons.Count, 0);
            }

            [Test]
            public void ThrowUpgradeWeaponWhenNoName()
            {
                Planet planet = new Planet("name", 100);
                Weapon weapon = new Weapon("name", 100, 20);
                planet.AddWeapon(weapon);
                Assert.Throws<InvalidOperationException>(() => planet.UpgradeWeapon("bla"));
            }
            [Test]
            public void UpgradeWeapon()
            {
                Planet planet = new Planet("name", 100);
                Weapon weapon = new Weapon("name", 100, 20);
                planet.AddWeapon(weapon);
                planet.UpgradeWeapon("name");
                Assert.AreEqual(weapon.DestructionLevel, 21);
            }
            [Test]
            public void ThrowOponent()
            {
                Planet plant = new Planet("name", 100);
                Weapon w = new Weapon("name", 100, 5);
                plant.AddWeapon(w);
                Planet oponent = new Planet("name", 200);
                Weapon oponentWeapon = new Weapon("bla", 200, 10);
                plant.AddWeapon(oponentWeapon);
                Assert.Throws<InvalidOperationException>(() => oponent.DestructOpponent(plant));
            }
            [Test]
            public void ThrowNameNull()
            {
                Assert.Throws<ArgumentException>(() => new Planet(String.Empty, 20));
                Assert.Throws<ArgumentException>(() => new Planet(null, 20));

            }
            [Test]
            public void ThrowBudjetBelouZero()
            {
                Assert.Throws<ArgumentException>(() => new Planet("name", -10));



            }
            [Test]
            public void ThrowOponentOk()
            {
                Planet plant = new Planet("name", 100);
                Weapon w = new Weapon("name", 100, 5);
                plant.AddWeapon(w);
                Planet oponent = new Planet("name", 200);
                Weapon oponentWeapon = new Weapon("bla", 200, 10);
                plant.AddWeapon(oponentWeapon);
                plant.DestructOpponent(oponent);
                var messages = "bla is destructed!";
                Assert.AreEqual(messages, "bla is destructed!");
            }
            [Test]
            public void ThrowWeaponPrice()
            {
                Planet planet = new Planet("name", 100);
               
                Assert.Throws<ArgumentException>(() => planet.AddWeapon(new Weapon("bla",-10,1)));
                
               

            }
            [Test]
            public void TestCtor()
            {
                Planet planet = new Planet("name", 100);
                Assert.AreEqual(planet.Name, "name");
                Assert.AreEqual(planet.Budget, 100);
            }
        }
    }
}
