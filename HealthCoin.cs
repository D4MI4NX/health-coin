using Exiled.API.Features;

namespace HealthCoin
{
    public class HealthCoin : Plugin<Config.Config>
    {
        /// <inheritdoc>
        public override string Name => "Health Coin";
    
        /// <inheritdoc>
        public override string Prefix => "HC";
        
        /// <inheritdoc>
        public override string Author => "D4MI4NX";
        
        /// <inheritdoc>
        public override Version Version => new Version(0, 1, 0);
        
        /// <inheritdoc>
        public override Version RequiredExiledVersion => new Version(8, 9, 11);

        public GenHandler? Handler { get; private set; }

        

        public override void OnEnabled()
        {
            Handler = new GenHandler();
            Handler.Start();

            base.OnEnabled();
        }
        
        /// <inheritdoc>
        public override void OnDisabled()
        {
            Handler.Stop();

            base.OnDisabled();
        }
    }
}
