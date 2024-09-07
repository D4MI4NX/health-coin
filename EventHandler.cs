using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using UnityEngine;
using Players = Exiled.Events.Handlers.Player;

namespace HealthCoin
{
    public class GenHandler
    {
        private readonly Config.Config? config;

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
            Log.Info("Threw coin");

            if (ev.IsTails)
            {
                ev.Player.Health += 50;
                ev.Player.Broadcast(5, $"The coin gave you 50 HP!");
            }
            else
            {
                ev.Player.Health -= 50;
                ev.Player.Broadcast(5, $"The coin took 50 HP from you!");
            }
        }
    }
}
