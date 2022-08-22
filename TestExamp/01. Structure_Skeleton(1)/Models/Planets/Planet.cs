using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Models.Planets
{
    public  class Planet : IPlanet
    {
        private string name;
        private double budget;
        private double militaryPower;
        private List<IMilitaryUnit> army;
        private List <IWeapon> weapons;

        public Planet(string name, double budget)
        {
            this.Name = name;
            this.Budget = budget;
            this.army = new List<IMilitaryUnit>();
            this.weapons = new List<IWeapon>();
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
                this.name = value;
            }
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
                this.budget = value;
            }
        }
        public double MilitaryPower
        {
            get { return militaryPower; }
            private set
            {
               value = army.Select(e => e.EnduranceLevel).Sum() + weapons.Select(d => d.DestructionLevel).Sum();

                if (army.GetType().Name == "AnonymousImpactUnit")
                {
                    value *= 1.3; 
                }
                if (weapons.GetType().Name == "NuclearWeapon")
                {
                    value *= 1.45;
                }
                
                this.militaryPower = Math.Round(value, 3);
            }
        }


        public IReadOnlyCollection<IMilitaryUnit> Army { get; }

        public IReadOnlyCollection<IWeapon> Weapons { get; }




        public void AddUnit(IMilitaryUnit unit)
        {
           army.Add(unit);
        }

        public void AddWeapon(IWeapon weapon)
        {
            weapons.Add(weapon);
        }

        public string PlanetInfo()
        {
           var sb = new StringBuilder();
            sb.AppendLine($"Planet: {Name}");
            sb.AppendLine($"--Budget: {Budget} billion QUID");
            if (army.Count == 0)
            {
                sb.AppendLine($"--Forces: No units");

            }
            else
            {
                var item = string.Join(", ", army.GetType().Name);
               
                    sb.AppendLine($"--Forces: {item}");
                    
               
            }
            if (weapons.Count == 0)
            {
                sb.AppendLine("--Combat equipment: No weapons");
            }
            else
            {
                var item = string.Join(", ", weapons.GetType().Name);
                {
                    sb.AppendLine($"--Combat equipment: {item}");
                  
                }
            }
            sb.AppendLine($"--Military Power: {militaryPower}");

            return sb.ToString().TrimEnd();
        }

        public void Profit(double amount)
        {
            budget+=amount;
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
            foreach (var item in army)
            {
                item.IncreaseEndurance();
            }
        }
    }
            
        
     
    }
