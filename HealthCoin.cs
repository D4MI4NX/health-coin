using Exiled.API.Features;

namespace HealthCoin
{
    public class HealthCoin : Plugin<Config.Config>
    {
        public override string Name => "Health Coin";
    
        public override string Prefix => "health_coin";
        
        public override string Author => "D4MI4NX";
        
        public override Version Version => new(1, 0, 0);
        
        public override Version RequiredExiledVersion => new(8, 9, 11);


        public GenHandler Handler { get; private set; }

        public override void OnEnabled()
        {
            Handler = new GenHandler(this);
            Handler.Start();

            base.OnEnabled();
        }
        
        public override void OnDisabled()
        {
            Handler?.Stop();

            base.OnDisabled();
        }

        public static implicit operator HealthCoin(GenHandler v)
        {
            throw new NotImplementedException();
        }
    }
}
