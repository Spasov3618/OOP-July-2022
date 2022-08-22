using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.MilitaryUnits
{
    public abstract class MilitaryUnit : IMilitaryUnit
    {
        private double cost;

        public MilitaryUnit(double cost)
        {
            this.Cost = cost;
        }

        private int enduranceLevel = 1;


        public double Cost 
        {
            get
            {
                return cost;
            }
                private set
            {
                this.cost = value;
            }
                }

        public int EnduranceLevel
        {
            get { return enduranceLevel; }
            set { enduranceLevel = value; } 
        }
        public void IncreaseEndurance()
        {
            enduranceLevel++;
            if (enduranceLevel>20)
            {
                enduranceLevel = 20;
                throw new ArgumentException(ExceptionMessages.EnduranceLevelExceeded);
            }
        }
    }
}
