using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetWars.Repositories
{
    public class WeaponRepository : IRepository<IWeapon>
    {
        private List<IWeapon> models;

        public WeaponRepository()
        {
            models = new List<IWeapon>();
        }

        public IReadOnlyCollection<IWeapon> Models => models;

        public void AddItem(IWeapon model)
        {
            models.Add(model);
        }

        public IWeapon FindByName(string name)
        {
            var search = models.FirstOrDefault(x =>x.GetType().Name == name);
            return search;
        }

        public bool RemoveItem(string name)
        {
            var search = models.FirstOrDefault(x => x.GetType().Name == name);
            if (search == null)
            {
                return false;
            }
            models.Remove(search);
            return true;
        }
    }
}
