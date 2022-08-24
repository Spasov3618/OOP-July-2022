﻿using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.Weapons
{
    public abstract class Weapon : IWeapon
    {
        private double price;
        private int destructionLevel;
       
        protected Weapon(double price, int destructionLevel)
        {
            this.DestructionLevel = destructionLevel;
            this.Price = price;
        }

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }
   


        public int DestructionLevel
        {
            get => this.destructionLevel;
            private set
            {
                if (value<1)
                {
                    throw new ArgumentException(ExceptionMessages.TooLowDestructionLevel);

                }
                else if (value>10)
                {
                    throw new ArgumentException(ExceptionMessages.TooHighDestructionLevel);
                }
                this.destructionLevel = value;
            }
        }
    }
}