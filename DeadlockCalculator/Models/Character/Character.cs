namespace DeadlockCalculator.Models
{
    public class Character
    {
        public String Name { get; set; } = string.Empty;
        public int Souls { get; set; } = 0;
        public GunStats GunStats { get; set; } = new GunStats();
        public VitalityStats VitalityStats { get; set; } = new VitalityStats();
        public SpiritStats SpiritStats { get; set; } = new SpiritStats();
        public Boon Boons { get; set; } = new Boon();
        public List<Item> Items { get; set; } = [];

        public Character()
        {
        }

        public Character(Character original)
        {
            Name = original.Name;
            Souls = original.Souls;
            GunStats = new GunStats(original.GunStats);
            VitalityStats = new VitalityStats(original.VitalityStats);
            SpiritStats = new SpiritStats(original.SpiritStats);
            Boons = new Boon(original.Boons);
            Items = new List<Item>(original.Items);
        }

        public void LevelUp()
        {
            GunStats.BulletDamage += Boons.BaseBulletDamage;
            VitalityStats.MaxHealth += Boons.BaseHealth;
            SpiritStats.SpiritPower += Math.Ceiling(Boons.SpiritPower);

        }
    }
}