namespace DeadlockCalculator.Models
{
    public class VitalityStats
    {
        public int MaxHealth { get; set; }
        public int HealAmp { get; set; }
        public int BulletResist { get; set; }
        public int MeleeResist { get; set; }
        public int CritReduction { get; set; } 
        public int HealthRegen { get; set; }
        public int NonCombatRegen { get; set; }
        public int SpiritResist { get; set; }
        public int DebuffResist { get; set; }
    }
}