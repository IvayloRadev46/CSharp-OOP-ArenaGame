using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class DeadmanPlate : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
        private int i = 0;
        private int j = 0;
//The weapon is used by Tank Heroes that do less damage in return for more survivability
        public DeadmanPlate(string name)
        {
            Name = name;
            AttackDamage = 10;
            BlockingPower = 20;
        }
//The weapon increases the max health of the user by 20 after their first attack
        public void UseSpecAbility(Hero attacker, Hero target)
        {
            if (i<1)
            {
                double healthIncrease = 20; 
                attacker.MaxHealth += healthIncrease;
                attacker.Health += healthIncrease; 
                Console.WriteLine($"{attacker.Name}'s max health increased by {healthIncrease}. New max health: {attacker.MaxHealth}");
                i = 1;
            }

            
                // Deal damage to the attacker based on the block power of the item
                double damageToAttacker = BlockingPower * 0.5;
                target.Health -= damageToAttacker;
                Console.WriteLine($"{target.Name} takes {damageToAttacker} damage from {Name}'s special ability.");
            
        }
    }
}