using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Repositories
{
    public class UnitRepository : IRepository<IMilitaryUnit>
    {
        private List<IMilitaryUnit> models;

        public UnitRepository()
        {
            models = new List<IMilitaryUnit>();
        }

        public IReadOnlyCollection<IMilitaryUnit> Models { get; }
        public void AddItem(IMilitaryUnit model)
        {
            models.Add(model);
        }

        public IMilitaryUnit FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool RemoveItem(string name)
        {
          var type = models.FirstOrDefault(n => n.GetType().Name == name);
            return models.Remove(type); 
        }
    }
}
