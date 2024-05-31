namespace ArenaGame.Heroes;

public class SpellCaster : Hero
{
    private double bonusAbilityPower;
    private static Random random = new Random();
    private double APScaling = 0.7;

    public SpellCaster(string name, double armor, double strength, IWeapon weapon, double bonusAbilityPower) : 
        base(name, armor, strength, weapon)
    {
        this.BonusAbilityPower = bonusAbilityPower;
    }
 //Damage scales of 70% of strength and 100% of the bonus ability power that weapons provide
    public override double Attack()
    {
        double AbilityPowerScale = Strength * APScaling;
        double damage = AbilityPowerScale + BonusAbilityPower;
        return damage;
    }
// Spellcasters have 20% chance to block 50% of damage 
    public override double Defend(double damage)
    {
        double probability = random.NextDouble();
        if (probability < 0.20)
        {
            damage *= 0.5; 
        }
        return base.Defend(damage);
    }
}