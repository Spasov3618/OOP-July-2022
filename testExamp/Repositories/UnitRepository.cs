using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Repositories
{
    public class UnitRepository : IRepository<IMilitaryUnit>
    {
        public UnitRepository()
        {

        }
        public IReadOnlyCollection<IMilitaryUnit> Models => throw new NotImplementedException();

        public void AddItem(IMilitaryUnit model)
        {
            throw new NotImplementedException();
        }

        public IMilitaryUnit FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool RemoveItem(string name)
        {
            throw new NotImplementedException();
        }
    }
}
