using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Models.Planets
{
    public class Planet : IPlanet
    {
        private UnitRepository units;
        private WeaponRepository weapons;
        private string name;
        private double budget;
        private double militaryPower;

        public Planet(string name, double budget)
        {
            this.Name = name;
            this.Budget = budget;
            this.units = new UnitRepository();
            this.weapons = new WeaponRepository();
           
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlanetName);
                }
                this.name = value; }
        }

        public double Budget
        {
            get { return budget; }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBudgetAmount);
                }
                budget = value;
            }
        }

        
        
        public double MilitaryPower
        {
            get => militaryPower;
             set
            {
                double total = units.Models.Sum(x => x.EnduranceLevel) + weapons.Models.Sum(x=>x.DestructionLevel);
                
                if (units.Models.GetType().Name == nameof(AnonymousImpactUnit))
                {
                    total *= 1.3;
                }
                if (weapons.Models.GetType().Name == nameof(NuclearWeapon))
                {
                    total *= 1.45;
                }
                value = total;
                this.MilitaryPower = Math.Round(value, 3);
            }
        }



        public IReadOnlyCollection<IMilitaryUnit> Army => units.Models;
        
            
       

        public IReadOnlyCollection<IWeapon> Weapons =>  weapons.Models;



        public void AddUnit(IMilitaryUnit unit)
        {
           units.AddItem(unit);
        }

        public void AddWeapon(IWeapon weapon)
        {
            weapons.AddItem(weapon);
        }


        public void Profit(double amount)
        {
           budget+= amount;
        }

        public void Spend(double amount)
        {
            if (budget<amount)
            {
                throw new InvalidOperationException(ExceptionMessages.UnsufficientBudget);
            }
            budget-=amount;
        }

        public void TrainArmy()
        {

            foreach (var item in units.Models)
            {
                item.IncreaseEndurance();
            }
            
        }

        public string PlanetInfo()
        {
           var sb= new StringBuilder();
            sb.AppendLine($"Planet: {this.Name}");
            sb.AppendLine($"--Budget: {Budget} billion QUID");

            var unit = string.Join(", ", units.Models.GetType().Name);
            if (unit == null)
            {
                sb.AppendLine("--Forces: No units");
            }
            else
            {
                foreach (var item in units.Models)
                {
                    sb.AppendLine(item.GetType().Name);
                }
            }
            var weapon = string.Join(", ", weapons.Models.GetType().Name);
            if (weapon == null)
            {
                sb.AppendLine("--Forces: No weapons");
            }
            else
            {
                foreach (var item in weapons.Models)
                {
                    sb.AppendLine(item.GetType().Name);
                }

            }
            sb.AppendLine($"--Military Power: {MilitaryPower}");
                return sb.ToString().TrimEnd();
        }
    }
}
