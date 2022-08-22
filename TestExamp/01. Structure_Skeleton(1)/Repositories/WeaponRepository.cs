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
        public IReadOnlyCollection<IWeapon> Models { get; }

        public void AddItem(IWeapon model)
        {
           models.Add(model);
        }

        public IWeapon FindByName(string name)
        {
           return models.FirstOrDefault(w =>w.GetType().Name == name);
        }

        public bool RemoveItem(string name)
        {
            var type = models.FirstOrDefault(n => n.GetType().Name == name);
         
            return models.Remove(type);
        }
    }
}
