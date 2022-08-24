using PlanetWars.Models.MilitaryUnits;
using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PlanetWars.Core.Contracts
{
    public class Controller : IController
    {
        private PlanetRepository planetRepository;

        public Controller()
        {
            planetRepository = new PlanetRepository();
        }

        public string CreatePlanet(string name, double budget)
        {
            var search = planetRepository.FindByName(name);
            if (search != null)
            {
                return String.Format(OutputMessages.ExistingPlanet, name);
            }
            Planet planet = new Planet(name, budget);
            planetRepository.AddItem(planet);
            return String.Format(OutputMessages.NewPlanet, planet.Name);
        }

        public string AddUnit(string unitTypeName, string planetName)
        {
            var search = planetRepository.FindByName(planetName);
            if (search == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }

            if (search.Army.Any(x => x.GetType().Name == unitTypeName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.UnitAlreadyAdded, unitTypeName, planetName));
            }

            IMilitaryUnit unit;
            if (unitTypeName == nameof(AnonymousImpactUnit))
            {
                unit = new AnonymousImpactUnit();
            }
            else if (unitTypeName == nameof(SpaceForces))
            {
                unit = new SpaceForces();
            }
            else if (unitTypeName == nameof(StormTroopers))
            {
                unit = new StormTroopers();

            }
            else
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.ItemNotAvailable, unitTypeName));
            }
            IPlanet planet = search;
            planet.AddUnit(unit);
            planet.Spend(unit.Cost);
            return String.Format(OutputMessages.UnitAdded, unitTypeName, planetName);
        }

        public string AddWeapon(string planetName, string weaponTypeName, int destructionLevel)
        {
            var search = planetRepository.FindByName(planetName);
            if (search == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }
            if (search.Weapons.Any(x => x.GetType().Name == weaponTypeName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.WeaponAlreadyAdded, weaponTypeName, planetName));
            }
            IWeapon weapon;
            if (weaponTypeName == nameof(SpaceMissiles))

            {
                weapon = new SpaceMissiles(destructionLevel);
            }
            else if (weaponTypeName == nameof(NuclearWeapon))
            {
                weapon = new NuclearWeapon(destructionLevel);
            }
            else if (weaponTypeName == nameof(BioChemicalWeapon))
            {
                weapon = new BioChemicalWeapon(destructionLevel);
            }
            else
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.ItemNotAvailable, weaponTypeName));
            }
            IPlanet planet = search;
            planet.AddWeapon(weapon);
            planet.Spend(weapon.Price);
            return String.Format(OutputMessages.WeaponAdded, planetName, weaponTypeName);
        }

        public string SpecializeForces(string planetName)
        {
            var search = planetRepository.FindByName(planetName);
            if (search == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.UnexistingPlanet, planetName));
            }
            if (search.Army.Count==0)
            {
                throw new InvalidOperationException(ExceptionMessages.NoUnitsFound);
            }

            search.TrainArmy();
           search.Spend(1.25);
            return String.Format(OutputMessages.ForcesUpgraded, planetName);
           
        }

        public string ForcesReport()
        {
            var sb = new StringBuilder();
            foreach (IPlanet item in planetRepository.Models)
            {
            sb.AppendLine(item.PlanetInfo());

            }
            return sb.ToString().TrimEnd();
        }

        public string SpaceCombat(string planetOne, string planetTwo)
        {
            throw new NotImplementedException();
        }

    }
}
