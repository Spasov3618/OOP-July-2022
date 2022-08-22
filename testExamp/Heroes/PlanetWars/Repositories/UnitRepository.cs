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

        public IReadOnlyCollection<IMilitaryUnit> Models => this.models;



        public void AddItem(IMilitaryUnit model)
        {
            models.Add(model);
        }

        public IMilitaryUnit FindByName(string name)
        {
            return models.FirstOrDefault(x => x.GetType().Name == name);
            
        }

        public bool RemoveItem(string name)
        {
            var search = models.FirstOrDefault(x=>x. GetType().Name == name);
            if (search == null)
            {
                return false;
            }
            models.Remove(search);
            return true;
        }
    }
}
