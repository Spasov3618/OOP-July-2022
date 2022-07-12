using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name, int power = 80) : base(name, power)
        {

        }
        public override string CastAbility()
        {
            return $"Rogue - {this.Name} hit for {this.Power} damage";
        }
        
    }
}
