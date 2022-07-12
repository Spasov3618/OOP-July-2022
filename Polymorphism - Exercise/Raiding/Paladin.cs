using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name, int power = 100) : base(name, power)
        {
        }
        public override string CastAbility()
        {
            return $"Paladin - {this.Name} healed for {this.Power}"; 
        }





    }
}

