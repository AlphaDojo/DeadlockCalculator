namespace DeadlockCalculator.Models
{
    public class Character
    {
        public required String name { get; set; }
        public GunStats gunStats { get; set; } = new GunStats();
        public VitalityStats vitalityStats { get; set; } = new VitalityStats();
        public SpiritStats spiritStats { get; set; } = new SpiritStats();
        public List<Item> Items { get; set; } = new List<Item>();
    }
}