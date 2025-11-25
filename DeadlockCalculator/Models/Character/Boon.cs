namespace DeadlockCalculator.Models
{
    public class Boon
    {
        public int level { get; private set; }
        public decimal BaseBulletDamage { get; set; }
        public decimal BaseMeleeDamage { get; set; }
        public decimal SpiritPower { get; set; }
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