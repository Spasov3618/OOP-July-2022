using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name, int power = 80) : base(name, power )
        {

        }
        public override string CastAbility()
        {
            return $"Druid - {this.Name} healed for {this.Power}";
        }
        
    }
}
