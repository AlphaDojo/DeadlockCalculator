namespace DeadlockCalculator.Models
{
    public class SpiritStats
    {
        public decimal SpiritPower { get; set; }
        public decimal AbilityCooldown { get; set; }
        public decimal AbilityRange { get; set; }
        public int MaxChargesIncrease { get; set; }
        public decimal AbilityDuration { get; set; }
        public int SpiritLifesteal { get; set; } 
        public int ChargeCooldown { get; set; }

        public SpiritStats()
        {
        }

        public SpiritStats(SpiritStats original)
        {
            SpiritPower = original.SpiritPower;
            AbilityCooldown = original.AbilityCooldown;
            AbilityRange = original.AbilityRange;
            MaxChargesIncrease = original.MaxChargesIncrease;
            AbilityDuration = original.AbilityDuration;
            SpiritLifesteal = original.SpiritLifesteal;
            ChargeCooldown = original.ChargeCooldown;
        }
    }
}