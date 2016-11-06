namespace SimpleToster.Configuration
{
    using Prism.Modularity;
    using Prism.Regions;

    using SimpleToster.Shared.Properties;

    public class ConfigarationModule : IModule
    {
        private readonly IRegionManager regionManager;

        public ConfigarationModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion(Resources.ConfigurationRegion, typeof(ConfigurationView));
        }
    }
}