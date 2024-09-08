using Exiled.API.Interfaces;

namespace HealthCoin.Config
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; } = false;

        public int AmntHeal { get; set; } = 25;

        public int AmntDamage { get; set; } = 25;
    }
}