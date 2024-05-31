namespace ArenaGame.Heroes;

public class FuryWarrior : Hero
    {
        private double rageThreshold = 30;
        private double rageMultiplier = 1.2;

        public FuryWarrior(string name, double armor, double strength, IWeapon weapon) : 
            base(name, armor, strength, weapon)
        {
           
        }
// Gains damage based on the strength until the threshhold is reached
        public override double Attack()
        {
            double damage = base.Attack();
            if (this.Strength < rageThreshold)
            {
                damage *= rageMultiplier;
            }
            return damage;
        }
     // Gain strength as more damage is taken
        public override double Defend(double damage)
        {
            double finalDamage = base.Defend(damage);
            this.Strength += finalDamage * 0.3; 
            return finalDamage;
        }
    }