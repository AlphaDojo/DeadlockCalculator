namespace DeadlockCalculator.Models
{
    public class GunStats
    {
        public double BulletDamage { get; set; }
        public double BulletPerSecond { get; set; }
        public int Ammo { get; set; }
        public double ReloadTime { get; set; }
        public int BulletVelocity { get; set; } 
        public int BulletLifesteal { get; set; }
        public int WeaponDamage { get; set; }
        public int FireRate { get; set; }
        public int ClipSizeIncrease { get; set; }
        public int ReloadReduction { get; set; }
        public int BulletVelocityIncrease { get; set; }
        public int CritBonusScale { get; set; }
    }
}