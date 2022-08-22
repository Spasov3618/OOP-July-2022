using Heroes.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Models.Weapons
{
    public abstract class Weapon : IWeapon
    {
        private string name;
        private int durability;
        private int damage;

        public Weapon(string name, int durability, int damage)
        {
            this.Name = name;
            this.Durability = durability;
            this.damage = damage;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Weapon type cannot be null or empty.");
                }
                name = value;
            }
        }

        public int Durability
        {
            get { return durability; }  
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Durability cannot be below 0.");
                }
               this. durability = value;
            }
        }

        public  int DoDamage()
        {
            durability--;
            if (durability<0)
            {
                return 0;
            }
            return durability;
        }
       
    }
}
