namespace DeadlockCalculator.Models
{
    public class Character
    {
        public String Name { get; set; }
        public int Boon { get; private set; }
        public int Souls { get; private set; }
        public GunStats GunStats { get; set; } = new GunStats();
        public VitalityStats VitalityStats { get; set; } = new VitalityStats();
        public SpiritStats SpiritStats { get; set; } = new SpiritStats();
        public Boon Boons { get; set; } = new Boon();
        public List<Item> Items { get; set; } = [];


        public Character(String name)
        {
            this.Name = name;
        }

        public void LevelUp()
        {
            GunStats.BulletDamage += Boons.BaseBulletDamage;
            VitalityStats.MaxHealth += Boons.BaseHealth;
            SpiritStats.SpiritPower += Math.Ceiling(Boons.SpiritPower);

        }
    }
}