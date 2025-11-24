namespace DeadlockCalculator.Models
{
    public class Boon
    {
        public int level { get; private set; }
        public double BaseBulletDamage { get; set; }
        public double BaseMeleeDamage { get; set; }
        public double SpiritPower { get; set; }
        public int BaseHealth { get; set; }

        public Boon()
        {
        }

        public Boon(Boon original)
        {
            level = original.level;
            BaseBulletDamage = original.BaseBulletDamage;
            BaseMeleeDamage = original.BaseMeleeDamage;
            SpiritPower = original.SpiritPower;
            BaseHealth = original.BaseHealth;
        }
    }
}