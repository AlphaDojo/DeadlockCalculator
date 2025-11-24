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

        public VitalityStats()
        {
        }

        public VitalityStats(VitalityStats original)
        {
            MaxHealth = original.MaxHealth;
            HealAmp = original.HealAmp;
            BulletResist = original.BulletResist;
            MeleeResist = original.MeleeResist;
            CritReduction = original.CritReduction;
            HealthRegen = original.HealthRegen;
            NonCombatRegen = original.NonCombatRegen;
            SpiritResist = original.SpiritResist;
            DebuffResist = original.DebuffResist;
        }
    }
}