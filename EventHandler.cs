using Exiled.Events.EventArgs.Player;
using Players = Exiled.Events.Handlers.Player;

namespace HealthCoin
{
    public class GenHandler
    {
        private readonly HealthCoin hc;

        public GenHandler(HealthCoin pluginInstance)
        {
            hc = pluginInstance;
        }

        public void Start()
        {
            Players.FlippingCoin += OnCoin;
        }

        public void Stop()
        {
            Players.FlippingCoin -= OnCoin;
        }

        public void OnCoin(FlippingCoinEventArgs ev)
        {
            int healAmount = hc.Config.AmntHeal;
            int damageAmount = hc.Config.AmntDamage;

            ev.Player.ClearBroadcasts();

            if (ev.IsTails)
            {
                ev.Player.Health -= damageAmount;
                ev.Player.Broadcast(5, string.Format("The coin took {0} HP from you!", damageAmount));
                if (ev.Player.Health <= 0)
                {
                    ev.Player.Kill("Unlucky!");
                }
            }
            else
            {
                ev.Player.Health += healAmount;
                ev.Player.Broadcast(5, string.Format("The coin gave you {0} HP!", healAmount));
            }
        }
    }
}
