using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGame.Weapons;

namespace ArenaGame
{
    public abstract class Hero : IHero
    {
        protected Random random = new Random();
        public string Name { get; private set; }
        public double Health { get; set; }
        public double Armor { get; private set; }
        public double Strength { get; protected set; }
        public IWeapon Weapon { get; private set; }
        public double MaxHealth { get; set; }
        
        public double BonusAbilityPower { get; set; }
        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public Hero(string name, double armor, double strenght, IWeapon weapon)
        {
            MaxHealth = 100;
            Health = MaxHealth;
            Name = name;
            Armor = armor;
            Strength = strenght;
            Weapon = weapon;
            BonusAbilityPower = 0;
           
        }


        // returns actual damage
        public virtual double Attack()
        {
            double totalDamage = Strength + Weapon.AttackDamage;
            double coef = random.Next(80, 120 + 1);
            double realDamage = totalDamage * (coef / 100);
            return realDamage;
            
        }

        public virtual double Defend(double damage)
        {
            double coef = random.Next(80, 120 + 1);
            double defendPower = (Armor + Weapon.BlockingPower) * (coef / 100);
            double realDamage = damage - defendPower;
            if (realDamage < 0)
                realDamage = 0;
            if (realDamage > 0)
            Health -= realDamage;
            return realDamage;
        }
        public void Heal(double amount)
        {
            // Ensure the healing amount does not exceed the hero's maximum health
            double newHealth = Health + amount;
            Health = Math.Min(newHealth, MaxHealth);
        }
        public override string ToString()
        {
            return $"{Name} with health {Math.Round(Health,2)}";
        }
    }
}
