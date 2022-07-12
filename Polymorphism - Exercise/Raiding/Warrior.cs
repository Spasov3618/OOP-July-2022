using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name, int power = 100) : base(name, power)
        {

        }

        public override string CastAbility()
        {
            return $"Warrior - {this.Name} hit for {this.Power} damage";
        }
       
    }
}
