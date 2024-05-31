using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGame.Heroes;

namespace ArenaGame.Weapons
{
    public class RodOfAges : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
        
        public double BonusAbilityPower { get; private set; }

        private double BonusAAPower = 40;
//Mage weapon that provides stacking ability power with each attack (doesn't have a cap), but has no blocking power
        public RodOfAges(string name)
        {
            Name = name;
            AttackDamage = 10;
            BlockingPower = 0;
            BonusAbilityPower = 30;
        }

        public void UseSpecAbility(Hero attacker, Hero target)
        {
            attacker.BonusAbilityPower += BonusAAPower;
            Console.WriteLine($"{attacker.Name} gains {BonusAAPower} ability power from {Name}.");
        }
    }
}