using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class BloodThirster : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
// A weapon that is used by attack damage Heroes that scale with damage and attacks
        public BloodThirster(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 5;
        }
       
        
//The special ability heals the user based on the damage they deal
        public void UseSpecAbility(Hero attacker, Hero target)
        {
            double damageDealt = attacker.Strength + attacker.Weapon.AttackDamage;
            double healAmount = damageDealt * 0.255;
            
            double potentialHealth = attacker.Health + healAmount;
            if (potentialHealth > attacker.MaxHealth)
            {
                healAmount = attacker.MaxHealth - attacker.Health;
            }
    
            attacker.Heal(healAmount);

    
            Console.WriteLine($"{attacker} was healed for {healAmount} health.");
        }
    }
}