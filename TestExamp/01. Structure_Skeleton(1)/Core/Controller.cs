﻿using PlanetWars.Core.Contracts;
using PlanetWars.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PlanetWars.Models.Planets;

namespace PlanetWars.Core
{
    public class Controller : IController
    {
        
        private PlanetRepository planets;

        public Controller()
        {
            planets = new PlanetRepository();
        }


        public string AddUnit(string unitTypeName, string planetName)
        {
            throw new NotImplementedException();
        }

        public string AddWeapon(string planetName, string weaponTypeName, int destructionLevel)
        {
            throw new NotImplementedException();
        }

        public string CreatePlanet(string name, double budget)
        {

            throw new NotImplementedException();
        }

        public string ForcesReport()
        {
            throw new NotImplementedException();
        }

        public string SpaceCombat(string planetOne, string planetTwo)
        {
            throw new NotImplementedException();
        }

        public string SpecializeForces(string planetName)
        {
            throw new NotImplementedException();
        }
    }
}
