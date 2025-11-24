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

        public GunStats()
        {
        }

        public GunStats(GunStats original)
        {
            BulletDamage = original.BulletDamage;
            BulletPerSecond = original.BulletPerSecond;
            Ammo = original.Ammo;
            ReloadTime = original.ReloadTime;
            BulletVelocity = original.BulletVelocity;
            BulletLifesteal = original.BulletLifesteal;
            WeaponDamage = original.WeaponDamage;
            FireRate = original.FireRate;
            ClipSizeIncrease = original.ClipSizeIncrease;
            ReloadReduction = original.ReloadReduction;
            BulletVelocityIncrease = original.BulletVelocityIncrease;
            CritBonusScale = original.CritBonusScale;
        }
    }
}