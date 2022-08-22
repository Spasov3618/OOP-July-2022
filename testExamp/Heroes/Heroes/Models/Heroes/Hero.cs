using Heroes.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Models.Heroes
{
    public abstract class Hero : IHero
    {
        private string name;
        private int health;
        private int armour;
        private IWeapon weapons;

        protected Hero(string name, int health, int armour)
        {
            this.Name = name;
            this.Health = health;
            this.Armour = armour;
            
            
        }

        public string Name
        {
            get { return name; }    
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hero name cannot be null or empty.");
                }    
                
               this. name = value;
            }
        }

        public int Health
        {
            get { return health; }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Hero health cannot be below 0.");
                }
               this. health = value;
            }
        }

        public int Armour
        {
            get { return armour; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero armour cannot be below 0.");
                }
                this.armour = value;
            }
        }
        public IWeapon Weapon
        {
            get { return weapons; }
            private set 
            {
                if (value == null)
                {
                    throw new ArgumentException("Weapon cannot be null.");
                }   
               this. weapons = value;
            }
        }



        public bool IsAlive => health > 0;


        public void AddWeapon(IWeapon weapon) => this.Weapon = weapon;
        

        public void TakeDamage(int points)
        {
            var left = this.Armour - points;

            if (left <0)
            {
                this.Armour = 0;
                var healthLeft = this.Health + left;
                if (healthLeft<0)
                {
                    this.Health = 0;
                }
                else
                {
                    Health=healthLeft;
                }

            }
            else
            {

                this.Armour = left;
            }

        }
    }
}
